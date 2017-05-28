#include "example.h"
typedef struct item_data {
	int index;
	Elm_Object_Item *item;
} item_data_s;
static char* gl_text_get_cb(void *data, Evas_Object *obj, const char *part) {
	const char *items[] = { "▶   내 강아지 사진 변경", "▶   수동 배식 관리", "▶   사료 알림 관리","▶   물 알림 관리" };
	item_data_s *id = data;
	if (!strcmp(part, "elm.text"))
	{
		return strdup(items[id->index]);
	}
return NULL;
}


static Evas_Object* gl_content_get_cb(void *data, Evas_Object *obj, const char *part) {
	item_data_s *id = data;
	 Evas_Object *check;
	//  ad->check3 = elm_check_add(ad->conform);
	  check = elm_check_add(obj);
	  elm_object_style_set(check, "on&off");
	  elm_object_text_set(check, "On / Off");
	  elm_check_state_set(check, EINA_FALSE);
	  evas_object_size_hint_min_set(check, 70, 70);
	  evas_object_size_hint_max_set(check, 70, 70);

if (!strcmp("elm.swallow.icon.1", part)){
	if(id->index==2||id->index==3){
		return check;
	}
	else
		return NULL;
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
static Evas_Object* create_button_view(Evas_Object *parent,Evas_Object *nf)
{
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
    evas_object_event_callback_add (label, EVAS_CALLBACK_MOUSE_DOWN, btn_back_cb,nf);


	evas_object_show(label);
	evas_object_show(label_forpet);

	/* List */
	/*const char *items[] = { "▶   내 강아지 사진 변경", "▶   수동 배식 관리", "▶   사료 알림 관리","▶   물 알림 관리"};
	Evas_Object *list = elm_list_add(grid);
	elm_genlist_item_append(list, itc,id,NULL, ELM_GENLIST_ITEM_NONE, NULL, id);
	elm_genlist_item_append(list, itc, id, NULL, NULL, (void*)0);
	elm_genlist_item_append(list, itc, id, NULL, NULL, (void*)1);
	elm_genlist_item_append(list, itc, id, NULL, notiM_item_clicked, (void*)2); //click the "알림 관리"
	elm_list_go(list);*/



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

	//num_of_item = 3;
	for (int i = 0; i < 4; i++) {
	item_data_s *id = calloc(sizeof(item_data_s), 1);
	id->index = i;
	it = elm_genlist_item_append(list, itc,id,NULL, ELM_GENLIST_ITEM_NONE, NULL, id);
	id->item = it;
	}

	//my_box_pack(box, list, 1.0, 1.0, -1.0, -1.0);
	elm_grid_pack(grid, list, 41, 200, 400,315);
	evas_object_show(list);


	    return grid;
   }


void setting_view_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *scroller, *layout;
	Evas_Object *nf = data;
	scroller = elm_scroller_add(nf);
	layout = create_button_view(scroller,nf);
	elm_object_content_set(scroller, layout);
	Elm_Object_Item *nf_it = elm_naviframe_item_push(nf,NULL, NULL, NULL,scroller, NULL);
	elm_naviframe_item_title_enabled_set(nf_it,EINA_FALSE,EINA_FALSE);
	 elm_object_item_data_set(nf_it, nf);

	evas_object_show(nf);

}

