#include "example.h"
#include "datetime.h"
#include <string.h>
#include <sqlite3.h>
#include <app.h>
#include <app_alarm.h>
#include <app_control.h>
#include <message_port.h>
#include <bundle.h>
#define TIME_12_FORMAT "%I:%M %p" //%I :hour 0-12 %M : minute %p:am/pm

typedef struct time_data {
	int tm_hour, tm_min;
	Elm_Object_Item *item;
	sqlite3 *db;
	Evas_Object * nf;
} time_data_s;

typedef struct check_data {
	Evas_Object *check1;
	Evas_Object *check2;
	Evas_Object *check3;
	Evas_Object *check4;
	Evas_Object *check5;
	Evas_Object *check6;
	Evas_Object *check7;
	char **select;
	int select_num;

} check_s;

typedef struct recdata {
	int tm_hour;
	int tm_min;

} recdata_s;

time_data_s *td;

static struct tm saved_time;
Evas_Object * popup;
Evas_Object * popup2;
Evas_Object * del_popup;
Evas_Object *datetime;
Evas_Object *scroller;
Evas_Object *nf;
Elm_Object_Item *it;
check_s ad;
Elm_Genlist_Item_Class *itc = NULL;
Evas_Object *genlist;
Eina_Bool rep_check;

char **service_data;
int count = 0;
//static struct tm * current;
static int read_db(time_data_s *id);
static void send_message(char*type, char*data);
void send_message2(char * data);
static void service_control(char * data);
static void make_popup_time(void *data, Evas_Object *obj, void *event_info);
static Evas_Object* gl_content_get_cb(void *data, Evas_Object *obj,
		const char *part);
static char* gl_text_get_cb(void *data, Evas_Object *obj, const char *part);
static void popup_set_btn_clicked_cb(void *data, Evas_Object *obj,
		void *event_info);
static void list_item_clicked(void *data, Evas_Object *obj, void *event_info);
static void gl_item_updated();
static int DeletRecord(time_data_s* id, int tm_hour, int tm_min) {
	char sql[256];
	char *ErrMsg;
	char *data = malloc(100);
	dlog_print(DLOG_INFO, "tag", "delete~~~");

	snprintf(sql, 256,
			"DELETE FROM feeding WHERE TM_HOUR = \'%d\' AND TM_MIN = \'%d\';",
			tm_hour, tm_min);
	dlog_print(DLOG_INFO, "tag", "%s", sql);
	int ret = sqlite3_exec(id->db, sql, NULL, 0, &ErrMsg);
	dlog_print(DLOG_INFO, "tag", "%d", ret);
	snprintf(data, 100, "%d,%d", tm_hour, tm_min);
	dlog_print(DLOG_INFO, "db", data);
	send_message("delete", data);

	return ret;

}

static int InsertRecord(time_data_s*id, int tm_hour, int tm_min) {
	int ret;
	char sql[256];
	char *ErrMsg;
	char *data = malloc(100);
	dlog_print(DLOG_INFO, "db", "insert");

	snprintf(sql, 256, "INSERT INTO feeding VALUES(%d,%d);", tm_hour, tm_min);
	snprintf(data, 100, "%d,%d", tm_hour, tm_min);
	dlog_print(DLOG_INFO, "db", data);

	ret = sqlite3_exec(id->db, sql, NULL, 0, &ErrMsg);
	//demo용

	send_message2(data);
	//send_message("TT",data);

	count++;

	return ret;
}

void send_message2(char * data) {
	int ret;
	const char* remote_app_id = "org.example.service";
	const char* remote_port = "myapplicationservice_service_port";

	bundle *b = bundle_create();
	bundle_add_str(b, "command", "들어가랏");
	bundle_add_str(b, "data", data);

	ret = message_port_send_message(remote_app_id, remote_port, b);
	if (ret != MESSAGE_PORT_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG,
				"message_port_check_remote_port error : %d", ret);
	} else {
		dlog_print(DLOG_INFO, LOG_TAG, "Send message done");
	}
	bundle_free(b);
}
//service로 data보내기
static void send_message(char*type, char*data) {
	int ret;
	const char* remote_app_id_ = "org.example.service";
	const char* remote_port_ = "forpet";

	bundle *b = bundle_create();
	bundle_add_str(b, "command", "insert");
	bundle_add_str(b, "data", data);

	ret = message_port_send_message("org.example.service", remote_port_, b);
	if (ret != MESSAGE_PORT_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG,
				"message_port_check_remote_port error : %d", ret);
	} else {
		dlog_print(DLOG_INFO, LOG_TAG, "Send message done");
	}
	bundle_free(b);
}

static int CreateTable(time_data_s*id) {

	char *ErrMsg;
	char *sql =
			"CREATE TABLE IF NOT EXISTS feeding(TM_HOUR INTEGER NOT NULL,TM_MIN INTEGER NOT NULL ,PRIMARY KEY(TM_HOUR,TM_MIN));";
	int ret = sqlite3_exec(id->db, sql, NULL, 0, &ErrMsg);
	return ret;

}

static char* gl_update_text_set_cb(void *data, Evas_Object *obj,
		const char *part) {
	char buf[1024];
	char temp[1024];

	char buff[100] = { 0 };

	strftime(buff, 200, TIME_12_FORMAT, &saved_time);
	if (!strcmp(part, "elm.text")) {
		strftime(buf, 1023, "%I: %M", &saved_time);
		return strdup(buf);
	} else if (!strcmp(part, "elm.text.end")) {
		strftime(buf, 1023, "%p         ", &saved_time);
		return strdup(buf);
	} else if (!strcmp(part, "elm.text.sub")) {
		if (ad.select_num < 1) {
			sprintf(temp, "%s", "알람");
			return strdup(temp);
		} //반복클릭안했을 경우
		else {

			sprintf(temp, "%s %s", "알람 ", ad.select[0]);
			for (int i = 1; i < ad.select_num; i++) {
				strcat(temp, " ");
				strcat(temp, ad.select[i]);
				dlog_print(DLOG_INFO, "user_tag0", temp);
				dlog_print(DLOG_INFO, "user_tag2", "들어옴");
			}
			rep_check = EINA_FALSE;
			return strdup(temp);
		}

	}

	else if (!strcmp("elm.text.sub.end", part)) {
		return strdup(" ");
	}

	return NULL;
}
static char* gl_text_update_cb(void *data, Evas_Object *obj, const char *part) {

	char buf[1024];
	char temp[1024];
	time_data_s* time = data;
	saved_time.tm_min = time->tm_min;
	saved_time.tm_hour = time->tm_hour;

	char buff[100] = { 0 };
	strftime(buff, 200, TIME_12_FORMAT, &saved_time);
	if (!strcmp(part, "elm.text")) {
		strftime(buf, 1023, "%I: %M", &saved_time);
		return strdup(buf);
	} else if (!strcmp(part, "elm.text.end")) {
		strftime(buf, 1023, "%p         ", &saved_time);
		return strdup(buf);
	} else if (!strcmp(part, "elm.text.sub")) {
		if (ad.select_num < 1) {
			sprintf(temp, "%s", "알람");
			return strdup(temp);
		} //반복클릭안했을 경우
		else {

			sprintf(temp, "%s %s", "알람 ", ad.select[0]);
			for (int i = 1; i < ad.select_num; i++) {
				strcat(temp, " ");
				strcat(temp, ad.select[i]);
			}
			rep_check = EINA_FALSE;
			return strdup(temp);
		}

	}

	else if (!strcmp("elm.text.sub.end", part)) {
		return strdup(" ");
	}

	return NULL;
}
static void gl_item_updated(recdata_s *rd) {

	saved_time.tm_hour = rd->tm_hour;
	saved_time.tm_min = rd->tm_min;

	itc->item_style = "type1";
	itc->func.text_get = gl_text_update_cb;
	itc->func.content_get = gl_content_get_cb;

	time_data_s* id = calloc(sizeof(time_data_s), 1);
	td->nf = nf;
	id->tm_min = saved_time.tm_min;
	id->tm_hour = saved_time.tm_hour;
	id->db = td->db;
	it = elm_genlist_item_append(genlist, itc, id, NULL, ELM_GENLIST_ITEM_NONE,
			list_item_clicked, td);
	td->item = it;
}
static int db_read_cb(void *counter, int argc, char **argv, char **azColName) {

	char buf[100];

	recdata_s* rd = malloc(sizeof(recdata_s));

	rd->tm_hour = atoi(argv[0]);
	rd->tm_min = atoi(argv[1]);

	snprintf(buf, 100, "%d,%d ", rd->tm_hour, rd->tm_min);
	send_message("data", buf);

	gl_item_updated(rd);

	return 0;
}
static int read_db(time_data_s *id) {
	char *sql = "select * from feeding";
	int counter = 0;

	char *ErrMsg;

	dlog_print(DLOG_INFO, "tag", "eonji~");
	int ret = sqlite3_exec(id->db, sql, db_read_cb, &counter, &ErrMsg);
	//dlog_print(DLOG_INFO,"tag",ret);a
	return ret;
}
//static int temp_index = 0;

static void init_db(time_data_s*id) {
	sqlite3_shutdown();
	sqlite3_config(SQLITE_CONFIG_URI, 1);
	sqlite3_initialize();
	char * resource = app_get_data_path();

	int siz = strlen(resource) + 10;
	char * path = malloc(sizeof(char) * siz);
	memset(path, 0, sizeof(char) * siz);

	strncat(path, resource, siz);
	strncat(path, "feeding.db", siz);
	dlog_print(DLOG_INFO, "user_tag0", path);
	sqlite3_open(path, &id->db);
	free(path);

	CreateTable(id);

	//read_db(id);
	//counter =0;
	read_db(id);
}

static void popup_block_clicked(void *data, Evas_Object *obj, void *event_info) {
	Evas_Object *nf = data;
	if (!obj)
		return;
	evas_object_del(obj);
	elm_popup_dismiss(obj);
	// evas_object_show(data);
} // block영역 클릭시 팝업창 종료
static void popup_closed_cb(void *data, Evas_Object *obj, void *event_info) {

	if (!obj)
		return;
	evas_object_del(del_popup);
	elm_popup_dismiss(del_popup);
}
static void popup_button_clicked(void *data, Evas_Object *obj, void *event_info) {
	Evas_Object *nf = data;

	if (!obj)
		return;
	evas_object_del(popup);
	elm_popup_dismiss(popup);
} // ok버튼 클릭시 팝업창 종료
static void check_changed_cb(void *data, Evas_Object *obj, void *event_info) {
	dlog_print(DLOG_INFO, "user_tag", "체크");
}
static void deleteDB(Elm_Object_Item *item) {

	char* sub_time[2] = { NULL, NULL };

	int hour;
	int min;

	//elm_object_item_part_text_get(item, "elm.txt");
	char* time = elm_object_item_part_text_get(item, "elm.text");
	//dlog_print(DLOG_INFO,"tag","%s text content",elm_object_item_part_text_get(item,"elm.text"));
	char* apm = elm_object_item_part_text_get(item, "elm.text.end");
	//dlog_print(DLOG_INFO,"tag","%s text content",elm_object_item_part_text_get(item,"elm.text.end"));

	//dlog_print(DLOG_INFO, "tag", time);
	//dlog_print(DLOG_INFO, "tag", apm);

	sub_time[0] = strtok(time, ": ");
	sub_time[1] = strtok(NULL, ": ");

	//dlog_print(DLOG_INFO, "tag", "%s %s %s", sub_time[0], sub_time[1], apm);

	if (!strcmp(apm, "PM         ")) {
		//dlog_print(DLOG_INFO,"tag","pm");
		hour = (atoi(sub_time[0]) + 12) % 24;
		if (hour == 0) {
			hour = 12;
		}
		//dlog_print(DLOG_INFO,"tag","pm");

	}

	else {
		hour = atoi(sub_time[0]);
		if (hour == 12) {
			hour = 0;
		}
	}

	min = atoi(sub_time[1]);

	//dlog_print(DLOG_INFO,"tag","%d %d", hour,min );
	count--;
	DeletRecord(td, hour, min);
}
static void gl_del_cb(time_data_s *id, Evas_Object *obj, void *event_info) {

	Elm_Object_Item *item = elm_genlist_selected_item_get(genlist);
	static int i = 0;
	dlog_print(DLOG_INFO, "tag", "%d", i);

	if (i == 0) {
		i++;
		deleteDB(item);
		elm_object_item_del(item);
		dlog_print(DLOG_INFO, "tag", "지우고~");
		if (!obj)
			return;
		evas_object_del(del_popup);
		dlog_print(DLOG_INFO, "tag", "팝업 지워~");
		elm_popup_dismiss(del_popup);
		dlog_print(DLOG_INFO, "tag", "끝");
		//counter=0;
		//  read_db(id);
		i = 0;
	} else {
		i = 0;

	}
}
//요일 반복 설정 ad.select에 check한 요일 저장.
static void rep_set_btn_clicked_cb(void *data, Evas_Object *obj,
		void *event_info) {

	int i = 0;

	ad.select = (char**) malloc(100);

	//buf[0] = malloc(sizeof("abcd"));

	if (elm_check_state_get(ad.check1) == EINA_TRUE) {
		ad.select[i] = malloc(sizeof("Sun"));
		ad.select[i] = "Sun";
		dlog_print(DLOG_INFO, "user_tag", ad.select[i]);
		dlog_print(DLOG_INFO, "user_tag", "설마");
		i++;
	}
	if (elm_check_state_get(ad.check2) == EINA_TRUE) {
		ad.select[i] = malloc(sizeof("Mon"));
		ad.select[i] = "Mon";
		dlog_print(DLOG_INFO, "user_tag", ad.select[i]);
		i++;
	}
	if (elm_check_state_get(ad.check3) == EINA_TRUE) {
		ad.select[i] = malloc(sizeof("Tue"));
		ad.select[i] = "Tue";
		dlog_print(DLOG_INFO, "user_tag", ad.select[i]);
		i++;
	}
	if (elm_check_state_get(ad.check4) == EINA_TRUE) {
		ad.select[i] = malloc(sizeof("Wed"));
		ad.select[i] = "Wed";
		dlog_print(DLOG_INFO, "user_tag", ad.select[i]);
	}
	if (elm_check_state_get(ad.check5) == EINA_TRUE) {
		ad.select[i] = malloc(sizeof("Thu"));
		ad.select[i] = "Thu";
		dlog_print(DLOG_INFO, "user_tag", ad.select[i]);
		i++;
	}
	if (elm_check_state_get(ad.check6) == EINA_TRUE) {
		ad.select[i] = malloc(sizeof("Fri"));
		ad.select[i] = "Fri";
		dlog_print(DLOG_INFO, "user_tag", ad.select[i]);
		i++;
	}
	if (elm_check_state_get(ad.check7) == EINA_TRUE) {
		ad.select[i] = malloc(sizeof("Sat"));
		ad.select[i] = "Sat";
		dlog_print(DLOG_INFO, "user_tag", ad.select[i]);
		i++;

	}

	ad.select_num = i;

	evas_object_del(popup2);
	elm_popup_dismiss(popup2);
	//Eina_Bool state = elm_check_state_get(obj);
}
//알람추가(list추가)
static void popup_set_btn_clicked_cb(void *data, Evas_Object *obj,
		void *event_info) {
	Evas_Object *nf = data;

	elm_datetime_value_get(datetime, &saved_time);

	InsertRecord(td, saved_time.tm_hour, saved_time.tm_min);
	evas_object_del(popup);
	itc->item_style = "type1";
	itc->func.text_get = gl_text_get_cb;
	itc->func.content_get = gl_content_get_cb;

	td->nf = nf;
	it = elm_genlist_item_append(genlist, itc, td, NULL, ELM_GENLIST_ITEM_NONE,
			list_item_clicked, td);
	td->item = it;

}
static void my_box_pack(Evas_Object *box, Evas_Object *child, double h_weight,
		double v_weight, double h_align, double v_align) {
	/* create a frame we shall use as padding around the child widget */
	Evas_Object *frame = elm_frame_add(box);
	elm_object_style_set(frame, "pad_medium");
	/* set the input weight/aling on the frame insted of the child */
	evas_object_size_hint_weight_set(frame, h_weight, v_weight);
	evas_object_size_hint_align_set(frame, h_align, v_align);
	{
		evas_object_size_hint_weight_set(child, EVAS_HINT_EXPAND,
		EVAS_HINT_EXPAND);
		evas_object_size_hint_align_set(child, EVAS_HINT_FILL, EVAS_HINT_FILL);
		/* actually put the child in the frame and show it */
		evas_object_show(child);
		elm_object_content_set(frame, child);
	} /* put the frame into the box instead of the child directly */
	elm_box_pack_end(box, frame); /* show the frame */
	evas_object_show(frame);
}
static void make_popup_rep(void * data, Evas_Object *obj, void *event_info) {

	Evas_Object *nf = data;
	//Evas_Object * check1,*check2,*check3,*check4,*check5,*check6,*check7;
	Evas_Object * box, *btn;

	popup2 = elm_popup_add(nf);

	elm_popup_align_set(popup2, ELM_NOTIFY_ALIGN_FILL, 0.5);

	evas_object_size_hint_weight_set(popup2, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);
	//elm_object_content_set(grid,popup);
	box = elm_box_add(popup2);
	btn = elm_button_add(box);
	elm_box_padding_set(box, 10, 0);
	elm_object_part_content_set(popup2, "button1", btn);

	elm_object_style_set(btn, "popup");
	elm_object_text_set(btn, "확인");
	evas_object_smart_callback_add(popup2, "block,clicked", popup_block_clicked,
			nf);
	eext_object_event_callback_add(popup2, EEXT_CALLBACK_BACK,
			eext_popup_back_cb, NULL);
	evas_object_smart_callback_add(btn, "clicked", rep_set_btn_clicked_cb, nf);
	//elm_object_part_content_set(popup2, "button1", btn);
	//elm_gengrid_horizontal_set(gengrid, EINA_TRUE);
//elm_box_horizontal_set(box,EINA_TRUE);
	ad.check1 = elm_check_add(box);

	ad.check2 = elm_check_add(box);
	ad.check3 = elm_check_add(box);
	ad.check4 = elm_check_add(box);
	ad.check5 = elm_check_add(box);
	ad.check6 = elm_check_add(box);

	ad.check7 = elm_check_add(box);

	elm_object_style_set(ad.check1, "popup");
	elm_object_style_set(ad.check2, "popup");
	elm_object_style_set(ad.check3, "popup");
	elm_object_style_set(ad.check4, "popup");
	elm_object_style_set(ad.check5, "popup");
	elm_object_style_set(ad.check6, "popup");
	elm_object_style_set(ad.check7, "popup");

	elm_object_text_set(ad.check1, "SUN");
	elm_object_text_set(ad.check2, "MON");
	elm_object_text_set(ad.check3, "TUE");
	elm_object_text_set(ad.check4, "WED");
	elm_object_text_set(ad.check5, "THU");
	elm_object_text_set(ad.check6, "FRI");
	elm_object_text_set(ad.check7, "SAT");

	elm_check_state_set(ad.check1, EINA_FALSE);
	elm_check_state_set(ad.check2, EINA_FALSE);
	elm_check_state_set(ad.check3, EINA_FALSE);
	elm_check_state_set(ad.check4, EINA_FALSE);
	elm_check_state_set(ad.check5, EINA_FALSE);
	elm_check_state_set(ad.check6, EINA_FALSE);
	elm_check_state_set(ad.check7, EINA_FALSE);

	my_box_pack(box, ad.check1, 1.0, 1.0, -1.0, -1.0);
	my_box_pack(box, ad.check2, 1.0, 1.0, -1.0, -1.0);
	my_box_pack(box, ad.check3, 1.0, 1.0, -1.0, -1.0);
	my_box_pack(box, ad.check4, 1.0, 1.0, -1.0, -1.0);
	my_box_pack(box, ad.check5, 1.0, 1.0, -1.0, -1.0);
	my_box_pack(box, ad.check6, 1.0, 1.0, -1.0, -1.0);
	my_box_pack(box, ad.check7, 1.0, 1.0, -1.0, -1.0);

	evas_object_show(ad.check1);
	evas_object_show(ad.check2);
	evas_object_show(ad.check3);
	evas_object_show(ad.check4);
	evas_object_show(ad.check5);
	evas_object_show(ad.check6);
	evas_object_show(ad.check7);
	evas_object_show(btn);
	evas_object_show(box);
	elm_object_content_set(popup2, box);

	evas_object_show(popup2);
}
static void make_popup_time(void *data, Evas_Object *obj, void *event_info) {
	ad.select_num = 0;
	Evas_Object * btn, *btn2, *grid;
	Evas_Object *nf = data;
	Evas_Object * check1, *check2, *check3, *check4, *check5, *check6, *check7;
	//Evas_Object * box;

	popup = elm_popup_add(nf);

	elm_popup_align_set(popup, ELM_NOTIFY_ALIGN_FILL, 0.5);

	evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	//elm_object_content_set(grid,popup);

	datetime = elm_datetime_add(popup);
	evas_object_size_hint_align_set(datetime, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_style_set(datetime, "time_layout");
	//elm_popup_pack(popup,datetime, 100, 100, 400,300);
	elm_object_content_set(popup, datetime);

	btn = elm_button_add(popup);
	btn2 = elm_button_add(popup);

	elm_object_style_set(btn, "popup");
	elm_object_text_set(btn, "확인");
	elm_object_part_content_set(popup, "button1", btn);
	elm_object_style_set(btn2, "popup");
	elm_object_text_set(btn2, "반복");
	elm_object_part_content_set(popup, "button2", btn2);
	evas_object_show(btn);
	evas_object_show(btn2);
	eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK,
			eext_popup_back_cb, NULL);
	evas_object_smart_callback_add(btn, "clicked", popup_set_btn_clicked_cb,
			nf);
	evas_object_smart_callback_add(btn2, "clicked", make_popup_rep, nf);
	evas_object_smart_callback_add(popup, "block,clicked", popup_block_clicked,
			nf);
	datetime = elm_datetime_add(popup);
	evas_object_size_hint_align_set(datetime, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_style_set(datetime, "time_layout");
	elm_object_content_set(popup, datetime);

	evas_object_show(datetime);
	//rep_check=EINA_FALSE;

	evas_object_show(popup);

}
static Evas_Object* create_image(Evas_Object *parent, char*s) {
	char img_path[PATH_MAX] = { 0, };
	app_get_resource(s, img_path, PATH_MAX);
	Evas_Object *img = elm_image_add(parent);
	elm_image_file_set(img, img_path, NULL);
	return img;
}

static void list_item_clicked(void *data, Evas_Object *obj, void *event_info) {

	dlog_print(DLOG_INFO, "tag", "make!");
	Evas_Object * yes_btn, *no_btn;
	Evas_Object * label;
	time_data_s *id = data;
	Evas_Object *nf = id->nf;
	del_popup = elm_popup_add(nf); //삭제여부 확인창
	elm_popup_align_set(del_popup, ELM_NOTIFY_ALIGN_FILL, 0.5);
	evas_object_size_hint_weight_set(del_popup, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);

	label = elm_label_add(del_popup);
	evas_object_size_hint_align_set(label, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_text_set(label,
			"<font_size=80><align=center>삭제하시겠습니까?</align></font size>");
	elm_object_content_set(del_popup, label);
	yes_btn = elm_button_add(del_popup);
	no_btn = elm_button_add(del_popup);
	elm_object_style_set(yes_btn, "popup");
	elm_object_text_set(yes_btn, "YES");
	elm_object_part_content_set(del_popup, "button1", yes_btn);
	elm_object_style_set(no_btn, "popup");
	elm_object_text_set(no_btn, "NO");
	elm_object_part_content_set(del_popup, "button2", no_btn);

	eext_object_event_callback_add(del_popup, EEXT_CALLBACK_BACK,
			eext_popup_back_cb, NULL);
	evas_object_smart_callback_add(yes_btn, "clicked", gl_del_cb, id);
	evas_object_smart_callback_add(no_btn, "clicked", popup_closed_cb, nf);
	evas_object_smart_callback_add(del_popup, "block,clicked",
			popup_block_clicked, nf);
	//evas_object_show(label);
	evas_object_show(yes_btn);
	evas_object_show(no_btn);
	evas_object_show(del_popup);
}

static Evas_Object* gl_content_get_cb(void *data, Evas_Object *obj,
		const char *part) {

	td = data;

	if (!strcmp("elm.swallow.icon", part)) {
		Evas_Object *content = create_image(obj, "clock.png");
		evas_object_size_hint_min_set(content, 70, 70);
		evas_object_size_hint_max_set(content, 70, 70);
		return content;
	}

	else if (!strcmp("elm.swallow.icon.1", part)) {
		Evas_Object *content = create_image(obj, "waste.png");
		evas_object_size_hint_min_set(content, 30, 30);
		evas_object_size_hint_max_set(content, 30, 30);
		return content;
	} else
		return NULL;
}

static char* gl_text_get_cb(void *data, Evas_Object *obj, const char *part) {
	char buf[1024];
	char temp[1024];
	dlog_print(DLOG_INFO, "get", "%d", saved_time.tm_min);
	char buff[100] = { 0 };
	strftime(buff, 200, TIME_12_FORMAT, &saved_time);
	if (!strcmp(part, "elm.text")) {
		strftime(buf, 1023, "%I: %M", &saved_time);
		return strdup(buf);
	} else if (!strcmp(part, "elm.text.end")) {
		strftime(buf, 1023, "%p         ", &saved_time);
		return strdup(buf);
	} else if (!strcmp(part, "elm.text.sub")) {
		if (ad.select_num < 1) {
			sprintf(temp, "%s", "알람");
			return strdup(temp);
		} //반복클릭안했을 경우
		else {

			sprintf(temp, "%s %s", "알람 ", ad.select[0]);
			for (int i = 1; i < ad.select_num; i++) {
				strcat(temp, " ");
				strcat(temp, ad.select[i]);
				dlog_print(DLOG_INFO, "user_tag0", temp);
				dlog_print(DLOG_INFO, "user_tag2", "들어옴");
			}
			rep_check = EINA_FALSE;
			return strdup(temp);
		}

	}

	else if (!strcmp("elm.text.sub.end", part)) {
		return strdup(" ");
	}

	return NULL;
}

static Evas_Object* create_button_view(Evas_Object *parent, Evas_Object *nf) {

	Evas_Object *btn, *img, *grid, *label, *list, *add, *label_forpet;
	//Elm_Genlist_Item_Class *itc = NULL;
	int i, num_of_item;

	grid = elm_grid_add(parent);

	elm_grid_size_set(grid, 480, 800);
	evas_object_size_hint_weight_set(grid, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	/* icon_reorder style */

	//elm_grid_pack(grid, bg, 0, 0, 480, 800);
	elm_bg_color_set(grid, 255, 255, 255);
	evas_object_show(grid);

	Evas_Object *bg = elm_bg_add(grid);
	elm_grid_pack(grid, bg, 0, 80, 480, 800);
	elm_bg_color_set(bg, 255, 255, 255);
	evas_object_show(bg);
	label = elm_label_add(grid);
	label_forpet = elm_label_add(grid);
	Evas_Object *rect = evas_object_rectangle_add(grid);
	evas_object_color_set(rect, 0, 204, 153, 255);
	elm_grid_pack(grid, rect, 0, 0, 480, 80);
	evas_object_show(rect);
	elm_object_text_set(label,
			"<font_size=80><align=center><color=#ffffff>FEEDING</align></font size></color>");

	elm_grid_pack(grid, label, 100, 10, 300, 150);
	//evas_object_smart_callback_add(btn, "clicked", btn_back_cb, nf);
	evas_object_event_callback_add(label, EVAS_CALLBACK_MOUSE_DOWN, btn_back_cb,
			nf);
	evas_object_show(label);
	itc = elm_genlist_item_class_new();

	/* Genlist */
	genlist = elm_genlist_add(grid);

	evas_object_size_hint_weight_set(genlist, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);

	elm_grid_pack(grid, genlist, 30, 130, 420, 500);

	td = calloc(sizeof(time_data_s), 1);
	init_db(td);

	elm_object_text_set(label_forpet,
			"<font_size=38><align=center><color=#000000>For Pet</align></font size></color>");
	elm_grid_pack(grid, label_forpet, 162, 730, 150, 150);
	evas_object_show(label_forpet);
	btn = elm_button_add(grid);
	elm_object_style_set(btn, "icon_expand_add");
	elm_grid_pack(grid, btn, 215, 655, 50, 50);
	evas_object_smart_callback_add(btn, "clicked", make_popup_time, nf);
	elm_genlist_realized_items_update(genlist);
	evas_object_show(genlist);
	evas_object_show(btn);

	return grid;
}

void feeding_view_cb(void *data, Evas_Object *obj, void *event_info) {

	Evas_Object *layout;
	nf = data;

	scroller = elm_scroller_add(nf);
	layout = create_button_view(scroller, nf);
	elm_object_content_set(scroller, layout);

	Elm_Object_Item *nf_it = elm_naviframe_item_push(nf, NULL, NULL, NULL,
			scroller, NULL);
	elm_naviframe_item_title_enabled_set(nf_it, EINA_FALSE, EINA_FALSE);
	elm_object_item_data_set(nf_it, nf);
	evas_object_show(nf);

}
