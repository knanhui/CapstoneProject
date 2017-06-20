#include "example.h"
#include "custombutton.h"
#include <sqlite3.h>
#include <stdlib.h>
#include <string.h>
#include <notification.h>
#include <efl_util.h>
#include <time.h>
#include <app.h>
#include <app_control.h>
#include <app_alarm.h>
#include <unistd.h>
#include <arpa/inet.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <pthread.h>
//#include <windows.h>
typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
	Evas_Object *grid_main;
	Evas_Object *img;
	Evas_Object *btn;
	Evas_Object *nf;
	Elm_Object_Item *nf_it;
	Evas_Object *list;
	Evas_Object *water_label;
	Evas_Object *feed_label;
	Evas_Object * scroller;
	// Database handle
	char *current_key;
} appdata_s;
typedef struct recdata {
	int tm_hour;
	int tm_min;

} recdata_s;

typedef struct item_data {
	int index;
	Elm_Object_Item *item;
	sqlite3 *db;
	Eina_Bool check_w;
	Eina_Bool check_f;
} item_data_s;

typedef struct setdata {
	int index;
	int onoff;
} setdata_s;

sqlite3 *db;
sqlite3 *setting_db;
appdata_s *m_ad;
setdata_s *sd;
Ecore_Timer *timer1;
item_data_s * id;
int check = 0;
int timer_count = 0;
#define  BUFF_SIZE   1024

pthread_mutex_t count_mutex = PTHREAD_MUTEX_INITIALIZER;
pthread_cond_t count_threshold_cv = PTHREAD_COND_INITIALIZER;
static void open_db(void * data);
static void open_setting_db(void * data);
win_delete_request_cb(void *data, Evas_Object *obj, void *event_info) {
	ui_app_exit();
}

static void win_back_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}

void app_get_resource(const char *res_file_in, char *res_path_out,
		int res_path_max) {
	char *res_path = app_get_resource_path();
	if (res_path) {
		snprintf(res_path_out, res_path_max, "%s%s", res_path, res_file_in);
		free(res_path);
	}
}

static Eina_Bool naviframe_pop_cb(void *data, Elm_Object_Item *it) {
	ui_app_exit();
	return EINA_FALSE;
}

static void create_base_gui(appdata_s *ad) {
	/* Window */
	/* Create and initialize elm_win.
	 elm_win is mandatory to manipulate window. */
	char img_path[PATH_MAX] = "";
	void * data;
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(ad->win, EINA_TRUE);

	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win,
				(const int *) (&rots), 4);
	}

	evas_object_smart_callback_add(ad->win, "delete,request",
			win_delete_request_cb, NULL);
	//eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb, ad);

	/* Conformant */
	/* Create and initialize elm_conformant.
	 elm_conformant is mandatory for base gui to have proper size
	 when indicator or virtual keypad is visible. */
	ad->conform = elm_conformant_add(ad->win);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);
	Evas_Object *table = elm_table_add(ad->win);
	/* Make table homogenous - every cell will be the same size */
	elm_table_homogeneous_set(table, EINA_TRUE);

	/* Let the table child allocation area expand within in the box */
	evas_object_size_hint_weight_set(table, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, table);
	evas_object_show(table);

	/* Naviframe */

	ad->nf = elm_naviframe_add(ad->conform);
	elm_object_content_set(ad->conform, ad->nf);

	evas_object_show(ad->nf);

	ad->grid_main = elm_grid_add(ad->nf);

	elm_grid_size_set(ad->grid_main, 480, 800);
	evas_object_size_hint_weight_set(ad->grid_main, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);
	evas_object_show(ad->grid_main);

	ad->nf_it = elm_naviframe_item_push(ad->nf, NULL, NULL, NULL, ad->grid_main,
	NULL);
	elm_naviframe_item_title_enabled_set(ad->nf_it, EINA_FALSE, EINA_FALSE);

//	eext_object_event_callback_add(ad->nf, EEXT_CALLBACK_BACK, eext_naviframe_back_cb, NULL);
	//elm_naviframe_item_pop_cb_set(ad->nf_it, naviframe_pop_cb,ad->grid_main);
	eext_object_event_callback_add(ad->nf, EEXT_CALLBACK_BACK,
			eext_naviframe_back_cb, NULL);
	elm_naviframe_item_pop_cb_set(ad->nf_it, naviframe_pop_cb, ad->win);
	//evas_object_show(ad->grid_main);
	Evas_Object *bg = elm_bg_add(ad->conform);
	elm_grid_pack(ad->grid_main, bg, 0, 0, 480, 800);
	elm_bg_color_set(bg, 255, 255, 255);
	evas_object_show(bg);

	/*label*/
	ad->water_label = elm_label_add(ad->grid_main);
	Evas_Object *rect = evas_object_rectangle_add(ad->grid_main);
	evas_object_color_set(rect, 0, 204, 153, 255);
	elm_grid_pack(ad->grid_main, rect, 0, 0, 480, 80);
	evas_object_show(rect);
	elm_grid_pack(ad->grid_main, ad->water_label, 150, 30, 300, 150);

	evas_object_show(ad->water_label);

	ad->feed_label = elm_label_add(ad->grid_main);
	//Evas_Object *rect = evas_object_rectangle_add(ad->grid_main);
	evas_object_color_set(rect, 0, 204, 153, 255);
	elm_grid_pack(ad->grid_main, rect, 0, 0, 480, 80);
	evas_object_show(rect);
	elm_grid_pack(ad->grid_main, ad->feed_label, 100, 100, 300, 150);

	evas_object_show(ad->feed_label);

	ad->label = elm_label_add(ad->grid_main);
	//Evas_Object *rect = evas_object_rectangle_add(ad->grid_main);
	evas_object_color_set(rect, 0, 204, 153, 255);
	elm_grid_pack(ad->grid_main, rect, 0, 0, 480, 80);
	evas_object_show(rect);
	elm_object_text_set(ad->label,
			"<font_size=80><align=center><color=#ffffff>For Pet</align></font size></color>");
	elm_grid_pack(ad->grid_main, ad->label, 100, 10, 300, 150);

	evas_object_show(ad->label);

	/*image*/

	app_get_resource("2.png", img_path, PATH_MAX);
	ad->img = evas_object_image_filled_add(ad->grid_main);
	evas_object_image_file_set(ad->img, img_path, NULL);
	elm_grid_pack(ad->grid_main, ad->img, 15, 200, 450, 480);
	evas_object_show(ad->img);

	/* Custom Button-1 */
	/* Canvas */
	Evas* canvas = evas_object_evas_get(ad->conform);

	ad->scroller = elm_scroller_add(ad->nf);

	//Evas_Object * m_bd1 = create_rect_set(canvas, ad->grid_main, 25,380, 80, 80);
//	m_bd1=create_text_set(canvas,ad->grid_main,25,380,80,80,"일지",NULL);
	buttondata_s* m_bd1 = create_button(canvas, ad->grid_main, 25, 380, 80, 80,
			"일지", NULL);
	evas_object_event_callback_add(m_bd1->text, EVAS_CALLBACK_MOUSE_DOWN,
			diary_view_cb, ad->nf);
	buttondata_s* m_bd2 = create_button(canvas, ad->grid_main, 98, 292, 80, 80,
			"통계", NULL);
	evas_object_event_callback_add(m_bd2->text, EVAS_CALLBACK_MOUSE_DOWN,
			statistics_view_cb, ad->nf);
	buttondata_s* m_bd3 = create_button(canvas, ad->grid_main, 202, 245, 80, 80,
			"바로<br>주기", NULL);
	evas_object_event_callback_add(m_bd3->text, EVAS_CALLBACK_MOUSE_DOWN,
			manual_view_cb, ad->nf);
	buttondata_s* m_bd4 = create_button(canvas, ad->grid_main, 304, 295, 80, 80,
			"배식<br>관리", NULL);
	evas_object_event_callback_add(m_bd4->text, EVAS_CALLBACK_MOUSE_DOWN,
			feeding_view_cb, ad->nf);
	buttondata_s* m_bd5 = create_button(canvas, ad->grid_main, 367, 395, 80, 80,
			"설정", NULL);
	evas_object_event_callback_add(m_bd5->text, EVAS_CALLBACK_MOUSE_DOWN,
			setting_view_cb, ad->nf);
	//evas_object_smart_callback_add(m_bd5->text, "clicked",setting_view_cb,ad);

	//appdata_s *temp = getAppdata();
	evas_object_show(ad->grid_main);

	evas_object_show(ad->win);

}

static Evas_Object * _my_elm_win_util_notification_add(const char *name,
		const char *title) {
	Evas_Object *win, *bg;
	dlog_print(DLOG_INFO, "tag", "main app");
	win = elm_win_add(NULL, name, ELM_WIN_NOTIFICATION); /* You should make a elm window as notification type */
	if (!win)
		return NULL;
	/*If you don't set window level this window will work like normal window even you made it as notification winodw */
	efl_util_set_notification_window_level(win,
			EFL_UTIL_NOTIFICATION_LEVEL_DEFAULT); /* You should set window level */

	elm_win_title_set(win, title);
	bg = elm_bg_add(win);
	if (!bg) {
		evas_object_del(win);
		return NULL;
	}
	evas_object_size_hint_weight_set(bg, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(win, bg);
	evas_object_show(bg);

	return win;
}
static Eina_Bool timer1_cb(void *data) {

	int ret;
	timer_count++;
	char buf[100];

	sprintf(buf, "Count - %d", timer_count);
	dlog_print(DLOG_DEBUG, "tag", "%s - %s", __func__, buf);
	struct tm date;
	int sec = 0;
	//ret = alarm_get_current_time(&date);
	//dlog_print(DLOG_DEBUG, "tag", "%d %d", date.tm_hour, date.tm_min);
	//alarm_app(data);
	return ECORE_CALLBACK_RENEW;
}

bool _app_control_extra_data_cb(app_control_h app_control, const char *key,
		void *data) {
	int ret;
	char *value;
	appdata_s *ad = data;
	ret = app_control_get_extra_data(app_control, key, &value);
	dlog_print(DLOG_DEBUG, "tag", "%s - %s", key, value);

	if (strcmp(key, "alarm") == 0 && strcmp(value, "water") == 0) {
		dlog_print(DLOG_DEBUG, "tag", "water!!!!!");
		elm_object_text_set(ad->label,
				"<font_size=80><align=center><color=#ffffff>물 부족</align></font size></color>");
	}
	if (strcmp(key, "alarm") == 0 && strcmp(value, "feed") == 0) {
		dlog_print(DLOG_DEBUG, "tag", "feed!!!!!");
		elm_object_text_set(ad->label,
				"<font_size=80><align=center><color=#ffffff>사료 부족</align></font size></color>");

	}
	return true;
}
void feeding_(void*data) {
	int sock;
	int server_addr_size;
	struct sockaddr_in server_addr;
	char buff_rcv[BUFF_SIZE + 5];
	char *message;

	sock = socket( PF_INET, SOCK_DGRAM, 0);
	dlog_print(DLOG_DEBUG, "service", "socket");
	if (-1 == sock) {
		printf("socket 생성 실패n");
		exit(1);
	}
	message = "m";

	memset(&server_addr, 0, sizeof(server_addr));
	server_addr.sin_family = AF_INET;
	server_addr.sin_port = htons(8888);
	server_addr.sin_addr.s_addr = inet_addr("192.168.0.85");

	sendto(sock, message, strlen(message) + 1, 0,
			(struct sockaddr*) &server_addr, sizeof(server_addr));

	dlog_print(DLOG_INFO, "tag", message);

	close(sock);

}

//static int temp_index = 0;

//setting db 읽어옴
static int setting_db_read_cb(void *counter, int argc, char **argv,
		char **azColName) {
	char buf[255];
	char buff[100];
	dlog_print(DLOG_INFO, "tag", "들어와!");
	sd = malloc(sizeof(recdata_s));

	sd->index = atoi(argv[0]);
	dlog_print(DLOG_INFO, "tag", "언지");
	sd->onoff = atoi(argv[1]);
	sprintf(buf, "%d / %d / ", atoi(argv[0]), atoi(argv[1]));
	if (sd->index == 1) {
		if (sd->onoff == 1) {
			id->check_f = EINA_FALSE;
			dlog_print(DLOG_INFO, "db", "여기 ㅠ");
		} else {
			id->check_f = EINA_TRUE;
			dlog_print(DLOG_INFO, "db", "여기ㅇㅇ ㅠ");
		}
	} else {
		if (sd->onoff == 1) {
			id->check_w = EINA_FALSE;
		} else {
			id->check_w = EINA_TRUE;
		}
	}

	return 0;
}
static int setting_read_db(void*data) {
	char *sql = "select * from ReportCard";
	int counter = 0;
	char *ErrMsg;
	// dlog_print(DLOG_INFO,"tag","eonji~");
	int ret = sqlite3_exec(setting_db, sql, setting_db_read_cb, id, &ErrMsg);
	//dlog_print(DLOG_INFO,"tag",ret);
	return ret;
}
//setting db열기
static int CreateTable(item_data_s*id) {

	char *ErrMsg;
	char *sql =
			"CREATE TABLE IF NOT EXISTS ReportCard(NUM INTEGER PRIMARY KEY, ONOFF INT NOT NULL);";
	int ret = sqlite3_exec(setting_db, sql, NULL, 0, &ErrMsg);
	return ret;

}
static int InsertRecord(item_data_s*td, int index, int onoff) {
	char sql[256];
	char *ErrMsg;
	dlog_print(DLOG_INFO, "tag", "insert~~~");
	snprintf(sql, 256, "INSERT INTO ReportCard VALUES(%d,%d);", index, onoff);

	int ret = sqlite3_exec(setting_db, sql, NULL, 0, &ErrMsg);
	return ret;
}
static int db_read_cb(void *counter, int argc, char **argv, char **azColName) {
	struct tm date;
	char buff[100];
	int sec = 0;
	dlog_print(DLOG_INFO, "tag", "들어와!");
	int ret = alarm_get_current_time(&date); //현재시간 date에 저장.
	//current = realloc(current,sizeof(recdata_s)*counter);
	char buf[100];

	recdata_s* rd = malloc(sizeof(recdata_s));
	dlog_print(DLOG_INFO, "tag", "언지");

	rd->tm_hour = atoi(argv[0]);
	rd->tm_min = atoi(argv[1]);

	if ((date.tm_hour == rd->tm_hour) && (date.tm_min == rd->tm_min)) {
		//feeding_(data);
		dlog_print(DLOG_DEBUG, "tag", "밥줘어엇!!!");
		feeding_(counter);
		snprintf(buff, 100, "rd->tm_hour %d rd->tm_min %d ", rd->tm_hour,
				rd->tm_min);
		snprintf(buf, 100, "%d,%d ", rd->tm_hour, rd->tm_min);
		dlog_print(DLOG_DEBUG, "tag", buf);

	}

//
	return 0;
}

static void open_setting_db(void * data) {
	sqlite3_shutdown();
	sqlite3_config(SQLITE_CONFIG_URI, 1);
	sqlite3_initialize();
	char * resource = app_get_data_path();
	int siz = strlen(resource) + 10;
	char * path = malloc(sizeof(char) * siz);
	memset(path, 0, sizeof(char) * siz);

	strncat(path, resource, siz);
	strncat(path, "test.db", siz);
	// dlog_print(DLOG_INFO, "user_tag0",path);
	sqlite3_open(path, setting_db);
	free(path);

	setting_read_db(id);
}
static int read_db(void*data) {
	char *sql = "select * from feeding";
	int counter = 0;

	char *ErrMsg;

	dlog_print(DLOG_INFO, "tag", "eonji~");
	int ret = sqlite3_exec(db, sql, db_read_cb, &counter, &ErrMsg);
	dlog_print(DLOG_INFO, "tag", "힝");
	return ret;
}
static void open_db(void * data) {
	sqlite3_shutdown();
	sqlite3_config(SQLITE_CONFIG_URI, 1);
	sqlite3_initialize();
	char * resource = app_get_data_path();

	int siz = strlen(resource) + 10;

	char * path = malloc(sizeof(char) * siz);
	memset(path, 0, sizeof(char) * siz);

	strncat(path, resource, siz);
	strncat(path, "feeding.db", siz);

	sqlite3_open(path, db);
	dlog_print(DLOG_DEBUG, "user_tag0", path);
	free(path);

	read_db(data);
}

void* run_app(appdata_s* data) {
	appdata_s* ad = data;
	dlog_print(DLOG_INFO, "run", "socket");
	int sock;
	int client_addr_size;
	setting_read_db(id);
	struct sockaddr_in server_addr;
	struct sockaddr_in client_addr;

	char buff_rcv[BUFF_SIZE + 5];
	char *message = "l";

	if (-1 == sock) {
		dlog_print(DLOG_INFO, "tag", "socket 생성 실패n");
		exit(1);
	}

	memset(&server_addr, 0, sizeof(server_addr));

	server_addr.sin_family = AF_INET;
	server_addr.sin_port = htons(8888);
	server_addr.sin_addr.s_addr = inet_addr("192.168.0.81");
	dlog_print(DLOG_INFO, "run", "connect");
	while (1) {

		memset(buff_rcv, 0, sizeof(buff_rcv));
		sock = socket( PF_INET, SOCK_DGRAM, 0);
		dlog_print(DLOG_INFO, "run", "new");
		sendto(sock, message, strlen(message) + 1, 0,
				(struct sockaddr*) &server_addr, sizeof(server_addr));

		dlog_print(DLOG_INFO, "run", "send");
		client_addr_size = sizeof(client_addr);

		recvfrom(sock, buff_rcv, BUFF_SIZE, 0, (struct sockaddr*) &client_addr,
				&client_addr_size);
		dlog_print(DLOG_INFO, "tag", "here");
		dlog_print(DLOG_INFO, "tag", "receive: %sn", buff_rcv);
		close(sock);

		if (strcmp(buff_rcv, "water") == 0 && id->check_w == EINA_TRUE) {
			dlog_print(DLOG_INFO, "water", "water");
			elm_object_text_set(ad->label,
					"<font_size=80><align=center><color=#ffffff>물 부족</align></font size></color>");

		}

		else if (strcmp(buff_rcv, "feed") == 0 && id->check_f == EINA_TRUE) {

			dlog_print(DLOG_INFO, "feed", "feed");
			elm_object_text_set(ad->label,
					"<font_size=80><align=center><color=#ffffff>사료 부족</align></font size></color>");
		} else {
			elm_object_text_set(ad->label,
					"<font_size=80><align=center><color=#ffffff>for pet</align></font size></color>");

		}
		sleep(2);
	}
	//return NULL;
}
static bool app_create(void *data) {
	/* Hook to take necessary actions before main event loop starts
	 Initialize UI resources and application's data
	 If this function returns true, the main loop of application starts
	 If this function returns false, the application is terminated */
	appdata_s *ad = data;

	create_base_gui(ad);

	//
	return true;
}
static void app_control(app_control_h app_control, void *data) {
	appdata_s *ad = data;
	pthread_t thread_t;

	pthread_create(&thread_t, NULL, run_app, ad);
	//pthread_t alarm_t;

	//dlog_print(DLOG_DEBUG, "tag", "왜안돼 ㅠㅠㅠ");
	//time_req();
	//timer1 = ecore_timer_add(1.0, timer1_cb, NULL);
	app_control_foreach_extra_data(app_control, _app_control_extra_data_cb, ad);

	return;
	/* Handle the launch request. */
}

static void app_pause(void *data) {
	/* Take necessary actions when application becomes invisible. */
	//time_req();
	//ecore_timer_thaw(timer1);
	//open_setting_db(id);
	//open_setting_db(id);

	open_setting_db(data);
	while (1) {
		//dlog_print(DLOG_DEBUG, "tag", "왜안돼 ㅠㅠㅠ");
		open_db(data);

		dlog_print(DLOG_DEBUG, "tag", "왜ㅠㅠㅠ");
		sleep(40);

	}
}

static void app_resume(void *data) {

	/* Take necessary actions when application becomes visible. */
}

static void app_terminate(void *data) {
	/* Release all resources. */
}

static void ui_app_lang_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LANGUAGE_CHANGED*/

	int ret;
	char *language;

	ret = app_event_get_language(event_info, &language);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG,
				"app_event_get_language() failed. Err = %d.", ret);
		return;
	}

	if (language != NULL) {
		elm_language_set(language);
		free(language);
	}
}

static void ui_app_orient_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void ui_app_region_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void ui_app_low_battery(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LOW_BATTERY*/
}

static void ui_app_low_memory(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LOW_MEMORY*/
}

int main(int argc, char *argv[]) {
	appdata_s ad = { 0, };
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = { 0, };
	app_event_handler_h handlers[5] = { NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY],
			APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY],
			APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED],
			APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED],
			APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED],
			APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}

	return ret;
}
