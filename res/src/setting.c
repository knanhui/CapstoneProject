#include "example.h"
#include <sqlite3.h>
#include <stdlib.h>


typedef struct item_data {
	int index;
	Elm_Object_Item *item;
	 sqlite3 *db;
	 Eina_Bool check_w;
	 Eina_Bool check_f;
} item_data_s;

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
	Evas_Object *grid_main;
	Evas_Object *img ;
	Evas_Object *btn;
	Evas_Object *nf;
	Evas_Object *list;
	Evas_Object * scroller;

	// Database handle
	char *current_key;
} appdata_s;


typedef struct recdata {
	int index;
	int onoff;
} recdata_s;

appdata_s *m_ad;
recdata_s* rd;
Evas_Object* list2;
recdata_s *current[2];

item_data_s * id;
item_data_s *id2;
static int InsertRecord(item_data_s*id, int index, int onoff)
{
	char sql[256];
	char *ErrMsg;
	dlog_print(DLOG_INFO,"tag","insert~~~");
	snprintf(sql, 256, "INSERT INTO ReportCard VALUES(%d,%d);",index, onoff);

	int ret = sqlite3_exec(id->db, sql, NULL, 0, &ErrMsg);
	return ret;
}
static int CreateTable(item_data_s*id) {

	char *ErrMsg;
	char *sql = "CREATE TABLE IF NOT EXISTS ReportCard(NUM INTEGER PRIMARY KEY, ONOFF INT NOT NULL);";
	int ret = sqlite3_exec(id->db, sql, NULL, 0, &ErrMsg);
	return ret;

}
static int db_read_cb(item_data_s*id, int argc, char **argv, char **azColName) {

	char buf[255];
	char buff[100];
	dlog_print(DLOG_INFO,"tag","들어와!");
	rd = malloc(sizeof(recdata_s));

	rd->index= atoi(argv[0]);
	dlog_print(DLOG_INFO,"tag","언지");
	rd->onoff= atoi(argv[1]);
	sprintf(buf, "%d / %d / ", atoi(argv[0]), atoi(argv[1]));
	if(rd->index ==1){
		if(rd->onoff==1){
			id->check_f=EINA_FALSE;
			dlog_print(DLOG_INFO,"db","여기 ㅠ");
		}
		else{
			id->check_f=EINA_TRUE;
			dlog_print(DLOG_INFO,"db","여기ㅇㅇ ㅠ");
		}
	}
	else{
		if(rd->onoff==1){
					id->check_w=EINA_FALSE;
				}
				else{
					id->check_w=EINA_TRUE;
				}
	}
	snprintf(buff,100,"rd->index %d rd->onoff %d ",rd->index,rd->onoff);
	/*current[(rd->index)-1]->index = atoi(argv[0]);
	current[(rd->index)-1]->onoff = atoi(argv[1]);
	*/dlog_print(DLOG_INFO,"db",buff);
	 elm_list_item_append(list2, buf, NULL, NULL, NULL, (void*)rd);
	 elm_list_go(list2);
    return 0;
}
	static int read_db(item_data_s *id) {
		char *sql = "select * from ReportCard";
		int counter=0;
		char *ErrMsg;
		 elm_list_clear(list2);
		 dlog_print(DLOG_INFO,"tag","eonji~");
		int ret = sqlite3_exec(id->db, sql, db_read_cb,id, &ErrMsg);
		//dlog_print(DLOG_INFO,"tag",ret);
		return ret;
	}
//static int temp_index = 0;
static int UpdateRecord(item_data_s*id, int index, int onoff) {
	char sql[256];
	char buff[100];
	char *ErrMsg;
	snprintf(buff,100,"index %d onoff %d ",index,onoff);
	dlog_print(DLOG_INFO,"tag2323",buff);
//	dlog_print(DLOG_INFO,"index",onoff);
	snprintf(sql, 256, "UPDATE ReportCard SET ONOFF=%d WHERE NUM=%d;",onoff,index);
	int ret = sqlite3_exec(id->db, sql, NULL, 0, &ErrMsg);

	return ret;
}


static void init_db(item_data_s*id) {
	sqlite3_shutdown();
	sqlite3_config(SQLITE_CONFIG_URI, 1);
	sqlite3_initialize();
	char * resource = app_get_data_path();
	int siz = strlen(resource) + 10;
	char * path = malloc(sizeof(char)*siz);
	memset( path, 0, sizeof( char ) * siz );


	strncat(path, resource, siz);
    strncat(path, "test.db", siz);
    dlog_print(DLOG_INFO, "user_tag0",path);
    sqlite3_open(path, &id->db);
    free(path);

    CreateTable(id);

    //read_db(id);

    InsertRecord(id,1,1);
    InsertRecord(id,2,1);


    read_db(id);
    }

static char* gl_text_get_cb(void *data, Evas_Object *obj, const char *part) {
	const char *items[] = {"▶   사료 알림 관리"};
	id = data;
	if (!strcmp(part, "elm.text"))
	{
		return strdup(items[0]);
	}
return NULL;
}
static char* gl_text2_get_cb(void *data, Evas_Object *obj, const char *part) {
	const char *items[] = {"▶   물 알림 관리" };
	id = data;
	if (!strcmp(part, "elm.text"))
	{
		return strdup(items[0]);
	}
return NULL;
}

static void check_changed_cb(void *data, Evas_Object *obj, void *event_info) {
	//appdata_s *ad = data;
	//id =data;
	int check_num = 0;
	Eina_Bool state = elm_check_state_get(obj);
		 if(state){
			 dlog_print(DLOG_INFO,"check","on");
			 UpdateRecord(id,1,2);
			 read_db(id);
		 }
		 else{
			 dlog_print(DLOG_INFO,"check","off");
			 UpdateRecord(id,1,1);
			 read_db(id);
		 }

}

static void check_changed2_cb(void *data, Evas_Object *obj, void *event_info) {
	//appdata_s *ad = data;
	//id =data;
	int check_num = 0;
	Eina_Bool state = elm_check_state_get(obj);

	{
		 if(state){
			 dlog_print(DLOG_INFO,"check2","on");
			 UpdateRecord(id2,2,2);
			 read_db(id2);
		 }
		 else{
			 dlog_print(DLOG_INFO,"check2","off");
			 UpdateRecord(id2,2,1);
			 read_db(id2);
		 }
		 //read_db(id);
	}


}

static Evas_Object* gl_content_get_cb(void *data, Evas_Object *obj, const char *part) {
	id = data;
	 Evas_Object *check;
	 check =elm_check_add(obj);
	 		elm_object_style_set(check, "on&off");
	 		elm_object_text_set(check, "On / Off");

	 		//elm_check_state_set(check, EINA_FALSE);
	 		evas_object_size_hint_min_set(check, 70, 70);
	 		evas_object_size_hint_max_set(check, 70, 70);

if (!strcmp("elm.swallow.icon.1", part)){

	/*if(current[(id->index)-2]->onoff == 1){
		elm_check_state_set(check, EINA_TRUE);
	}
	else{
		elm_check_state_set(check, EINA_FALSE);
	}
*/

		 				elm_check_state_set(check,id->check_f);


		 evas_object_smart_callback_add(check, "changed", check_changed_cb,id);
		 return check;
}





		else return NULL;
}

static Evas_Object* gl_content2_get_cb(void *data, Evas_Object *obj, const char *part) {
	id = data;
	 Evas_Object *check;
	 check =elm_check_add(obj);
	 elm_object_style_set(check, "on&off");
	 elm_object_text_set(check, "On / Off");

	 		//elm_check_state_set(check, EINA_FALSE);
	 		evas_object_size_hint_min_set(check, 70, 70);
	 		evas_object_size_hint_max_set(check, 70, 70);

	 		if (!strcmp("elm.swallow.icon.1", part)){

	/*if(current[(id->index)-2]->onoff == 1){
		elm_check_state_set(check, EINA_TRUE);
	}
	else{
		elm_check_state_set(check, EINA_FALSE);
	}
*/


		elm_check_state_set(check,id->check_w);
		//id->check_w=check;
		evas_object_smart_callback_add(check, "changed", check_changed2_cb,id);
		return check;
	 		}


		else return NULL;
}

/*static void notiM_item_clicked(void *data, Evas_Object *obj, void *event_info)
{
	int index = (int)data;
	Elm_Object_Item *it = event_info;
	const char *item_text = elm_object_item_text_get(it);
	char buf[PATH_MAX];
	sprintf(buf, "%d - %s", index, item_text);
	dlog_print(DLOG_INFO, "tag", "%s", buf);


}*/
static Evas_Object* create_button_view(Evas_Object *parent,appdata_s *ad)
{

	m_ad =ad;
	 dlog_print(DLOG_INFO,"user","on");
	Evas_Object *btn, *img, *grid,*label,*label_forpet;
	grid = elm_grid_add(parent);

	elm_grid_size_set(grid, 480, 800);
	evas_object_size_hint_weight_set(grid, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
    /* icon_reorder style */
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
	elm_object_text_set(label, "<font_size=80><align=center><color=#ffffff>SETTING</align></font size></color>");
	elm_grid_pack(grid, label, 100, 10, 300, 150);
	elm_object_text_set(label_forpet, "<font_size=38><align=center><color=#000000>For Pet</align></font size></color>");
		elm_grid_pack(grid, label_forpet, 160, 730,150, 150);
    evas_object_event_callback_add (label, EVAS_CALLBACK_MOUSE_DOWN, btn_back_cb,ad->nf);


	evas_object_show(label);
	evas_object_show(label_forpet);

				/* Genlist */
	Elm_Genlist_Item_Class *itc = NULL;
	Elm_Object_Item *it;
	//list = elm_genlist_add(grid);
	Evas_Object *list = elm_genlist_add(grid);
	itc = elm_genlist_item_class_new();
	itc->item_style  = "type1";
	itc->func.text_get = gl_text_get_cb;
	itc->func.content_get = gl_content_get_cb;
	itc->func.del = NULL;

	Elm_Genlist_Item_Class *itc2 = NULL;
	Elm_Object_Item *it2;
	//list = elm_genlist_add(grid);
	Evas_Object *list3 = elm_genlist_add(grid);
	itc2 = elm_genlist_item_class_new();
	itc2->item_style  = "type1";
	itc2->func.text_get = gl_text2_get_cb;
	itc2->func.content_get = gl_content2_get_cb;
	itc2->func.del = NULL;


	dlog_print(DLOG_INFO,"user2","on");
	//num_of_item = 3;




	id = calloc(sizeof(item_data_s), 1);
	it = elm_genlist_item_append(list, itc,id,NULL, ELM_GENLIST_ITEM_NONE, NULL, id);
	id->item = it;

	id2 = calloc(sizeof(item_data_s), 1);
	it2 = elm_genlist_item_append(list3, itc2,id2,NULL, ELM_GENLIST_ITEM_NONE, NULL, id2);
	id2->item = it2;

	init_db(id);
	init_db(id2);

	list2 = elm_list_add(grid);
	 elm_list_mode_set(list2, ELM_LIST_COMPRESS);
	 elm_list_go(list2);
	 elm_grid_pack(grid,list2,41,600,400,200);
	//my_box_pack(box, list, 1.0, 1.0, -1.0, -1.0);
	elm_grid_pack(grid, list, 41, 300, 400,100);
	elm_grid_pack(grid, list3, 41, 450, 400,100);
	evas_object_show(list);

	evas_object_show(list3);
	evas_object_show(list2);

	    return grid;
   }


void setting_view_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s * ad;
	//init_db(id);



	Evas_Object *scroller, *layout;
	Evas_Object *nf = data;

	scroller = elm_scroller_add(nf);
	ad->nf=nf;
	layout = create_button_view(scroller,ad);
	elm_object_content_set(scroller, layout);
	Elm_Object_Item *nf_it = elm_naviframe_item_push(ad->nf,NULL, NULL, NULL,scroller, NULL);
	elm_naviframe_item_title_enabled_set(nf_it,EINA_FALSE,EINA_FALSE);
	 elm_object_item_data_set(nf_it, ad->nf);

	evas_object_show(ad->nf);

}
