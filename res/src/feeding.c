#include "example.h"
#include "datetime.h"
#define TIME_12_FORMAT "%I:%M %p" //%I :hour 0-12 %M : minute %p:am/pm
typedef struct item_data {
	int index;
	char * time; //시간
	int id; //오전=0,오후=1;
	Elm_Object_Item *item;
} item_data_s;

static struct tm saved_time;
Evas_Object * popup;
Evas_Object * popup2;
Evas_Object *datetime;
Elm_Object_Item *it;
Elm_Genlist_Item_Class *itc=NULL;
Evas_Object *genlist;
static Evas_Object* gl_content_get_cb(void *data, Evas_Object *obj, const char *part);
static char* gl_text_get_cb(void *data, Evas_Object *obj, const char *part);
 static void popup_block_clicked(void *data, Evas_Object *obj, void *event_info) {
Evas_Object *nf = data;
	 if(!obj) return;
	 evas_object_del(obj);
	 	elm_popup_dismiss(obj);
	// evas_object_show(data);
} // block영역 클릭시 팝업창 종료

 static void popup_button_clicked(void *data, Evas_Object *obj, void *event_info) {
Evas_Object *nf = data;

	 if(!obj) return;
	 evas_object_del(popup);
	 elm_popup_dismiss(popup);
} // ok버튼 클릭시 팝업창 종료

 static void
 popup_set_btn_clicked_cb(void *data , Evas_Object *obj , void *event_info){
	 char buff[200] = {0};


	 elm_datetime_value_get(datetime,&saved_time);
	 strftime(buff, 200, TIME_12_FORMAT,&saved_time);

	 	 	dlog_print(DLOG_INFO, "user_tag", buff);
	 if(!obj) return;
	 evas_object_del(popup);
	 itc->item_style  = "type1";
	 			itc->func.text_get = gl_text_get_cb;
	 			itc->func.content_get = gl_content_get_cb;
	 			itc->func.del = NULL;

	 item_data_s *id = calloc(sizeof(item_data_s), 1);
	// id->index = i;
	 it = elm_genlist_item_append(genlist, itc,id,NULL, ELM_GENLIST_ITEM_NONE, NULL, id);
	 id->item = it;




	 //	 elm_popup_dismiss(popup);
 }
 static void make_popup_rep(void * data,Evas_Object *obj, void *event_info){
	 	 Evas_Object *nf = data;
	 	Evas_Object * check1,*check2,*check3,*check4,*check5,*check6,*check7;
	 	Evas_Object * box,*btn;

	 	popup2 = elm_popup_add(nf);

	 	elm_popup_align_set(popup2,  ELM_NOTIFY_ALIGN_FILL, 0.5);


	 	evas_object_size_hint_weight_set(popup2, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	 	//elm_object_content_set(grid,popup);
	 	box=elm_box_add(popup2);
	 	btn = elm_button_add(box);
	 	elm_object_style_set(btn, "popup");
	 			elm_object_text_set(btn, "확인");
	 			//elm_object_part_content_set(popup2, "button1", btn);

		check1=elm_check_add(box);
		check2=elm_check_add(box);
		check3=elm_check_add(box);
		check4=elm_check_add(box);
		check5=elm_check_add(box);
		check6=elm_check_add(box);

		check7=elm_check_add(box);


	 elm_object_part_text_set(check1,"elm.text", "일");
	 elm_box_pack_end(box,check1);
	 elm_object_part_text_set(check2,"elm.text", "월");
	 elm_object_part_text_set(check3,"elm.text", "화");
	 elm_object_part_text_set(check4, "elm.text","수");
	 elm_object_part_text_set(check5,"elm.text", "목");
	 elm_object_part_text_set(check6,"elm.text", "금");
	 elm_object_part_text_set(check7,"elm.text", "토");

	 elm_box_pack_end(box,check2);
	 elm_box_pack_end(box,check3);
	 elm_box_pack_end(box,check4);
	 elm_box_pack_end(box,check5);
	 elm_box_pack_end(box,check6);
	 elm_box_pack_end(box,check7);
	 elm_box_pack_end(box,btn);



		 evas_object_show(check1);
		 evas_object_show(check2);
		 evas_object_show(check3);
		 evas_object_show(check4);
		 evas_object_show(check5);
		 evas_object_show(check6);
		 evas_object_show(check7);
		 evas_object_show(btn);
		 evas_object_show(box);
		 elm_object_content_set(popup2,box);
		 evas_object_show(popup2);
 }
 static void make_popup_time(void *data, Evas_Object *obj, void *event_info) {
/*Evas_Object * btn,*btn2,*grid;
	Evas_Object *nf = data;
	Evas_Object * check1,*check2,*check3,*check4,*check5,*check6,*check7;
	//Evas_Object * box;

	popup = elm_popup_add(nf);

	elm_popup_align_set(popup,  ELM_NOTIFY_ALIGN_FILL, 0.5);


	evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	//elm_object_content_set(grid,popup);



		datetime = elm_datetime_add(popup);
				evas_object_size_hint_align_set(datetime, EVAS_HINT_FILL, EVAS_HINT_FILL);
				elm_object_style_set(datetime, "time_layout");
				//elm_popup_pack(popup,datetime, 100, 100, 400,300);
				elm_object_content_set(popup,datetime);



	btn = elm_button_add(popup);
	btn2=elm_button_add(popup);

		elm_object_style_set(btn, "popup");
		elm_object_text_set(btn, "확인");
		elm_object_part_content_set(popup, "button1", btn);
		elm_object_style_set(btn2,"popup");
		elm_object_text_set(btn2,"반복");
		elm_object_part_content_set(popup,"button2",btn2);
		evas_object_show(btn);
		evas_object_show(btn2);
		 eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK, eext_popup_back_cb, NULL);
		evas_object_smart_callback_add(btn, "clicked", popup_set_btn_clicked_cb,nf);
		evas_object_smart_callback_add(btn2, "clicked", make_popup_rep,nf);
		evas_object_smart_callback_add(popup,"block,clicked",popup_block_clicked,nf);
		datetime = elm_datetime_add(popup);
		evas_object_size_hint_align_set(datetime, EVAS_HINT_FILL, EVAS_HINT_FILL);
		elm_object_style_set(datetime, "time_layout");
		elm_object_content_set(popup,datetime);


		evas_object_show(datetime);





			 evas_object_show(popup);*/

	 Evas_Object * btn,*btn2,*grid;
	 	Evas_Object *nf = data;
	 	Evas_Object * check1,*check2,*check3,*check4,*check5,*check6,*check7;
	 	grid=elm_grid_add(nf);
	 	popup = elm_popup_add(grid);
	 	evas_object_show(popup);

	 	elm_popup_align_set(popup,  ELM_NOTIFY_ALIGN_FILL,1.0);
	 	elm_object_style_set(grid, "popup");


	 	//elm_grid_size_set(grid,480, 800);
	 	evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	 	 evas_object_size_hint_weight_set(grid, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);




	 		datetime = elm_datetime_add(grid);
	 				evas_object_size_hint_align_set(datetime, EVAS_HINT_FILL, EVAS_HINT_FILL);
	 				elm_object_style_set(datetime, "time_layout");
	 				//elm_popup_pack(popup,datetime, 100, 100, 400,300);
	 				//elm_object_content_set(popup,datetime);
	 				elm_grid_pack(grid,datetime,100,100,400,300);
	 				evas_object_show(datetime);



	 	btn = elm_button_add(grid);
	 	//btn2=elm_button_add(popup);

	 		elm_object_style_set(btn, "popup");
	 		elm_object_text_set(btn, "확인");
	 		elm_object_part_content_set(grid, "button1", btn);

	 		evas_object_show(btn);

	 		 eext_object_event_callback_add(grid, EEXT_CALLBACK_BACK, eext_popup_back_cb, NULL);
	 		evas_object_smart_callback_add(btn, "clicked", popup_set_btn_clicked_cb,nf);

	 		evas_object_smart_callback_add(grid,"block,clicked",popup_block_clicked,nf);









	 		evas_object_show(grid);


}
static Evas_Object* create_image(Evas_Object *parent,char*s)
{
	char img_path[PATH_MAX] = { 0, };
	app_get_resource(s, img_path, PATH_MAX);
	Evas_Object *img = elm_image_add(parent);
	elm_image_file_set(img, img_path, NULL);
	return img;
}



static Evas_Object* gl_content_get_cb(void *data, Evas_Object *obj, const char *part) {

	item_data_s *id = data;


if (!strcmp("elm.swallow.icon", part)){
	Evas_Object *content= create_image(obj,"clock.png");
			evas_object_size_hint_min_set(content, 70, 70);
			evas_object_size_hint_max_set(content, 70, 70);
			return content;
}

		else if (!strcmp("elm.swallow.icon.1", part)){
			Evas_Object *content= create_image(obj,"waste.png");
					evas_object_size_hint_min_set(content, 30, 30);
					evas_object_size_hint_max_set(content, 30, 30);
					return content;
		}
		else return NULL;
}

static char*
gl_text_get_cb(void *data, Evas_Object *obj, const char *part)
{
	item_data_s *id = data;
	char buf[1024];

	/* Make text on first list item */

	/*	if (!strcmp(part, "elm.text")) {
			snprintf(buf, 1023, "%I: %M",&saved_time);
			return strdup(buf);
		} else if (!strcmp(part, "elm.text.end")) {
			snprintf(buf, 1023, "%p",&saved_time);
			return strdup(buf);
		} else if (!strcmp(part, "elm.text.sub")) {
			snprintf(buf, 1023, "%s", "Wed");

			return strdup(buf);
		}*/
	char buff [100]={0};
	strftime(buff, 200, TIME_12_FORMAT,&saved_time);


		if (!strcmp(part, "elm.text")) {
			strftime(buf, 1023, "%I: %M",&saved_time);
						return strdup(buf);
					} else if (!strcmp(part, "elm.text.end")) {
						strftime(buf, 1023, "%p         ", &saved_time);
						return strdup(buf);
					} else if (!strcmp(part, "elm.text.sub")) {
						if(saved_time.tm_wday==1){
							snprintf(buf, 1023, "%s", "월");
						}


						return strdup(buf);
					}
				else if (!strcmp("elm.text.sub.end", part)){
				return strdup(" ");
			}




	return NULL;
}

static Evas_Object* create_button_view(Evas_Object *parent,Evas_Object *nf)
{
	Evas_Object *btn, *img, *grid,*label,*list,*add,*label_forpet;
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
	elm_object_text_set(label, "<font_size=80><align=center><color=#ffffff>FEEDING</align></font size></color>");

	elm_grid_pack(grid, label, 100, 10, 300, 150);
    //evas_object_smart_callback_add(btn, "clicked", btn_back_cb, nf);
    evas_object_event_callback_add (label, EVAS_CALLBACK_MOUSE_DOWN, btn_back_cb,nf);
	evas_object_show(label);
	itc = elm_genlist_item_class_new();


			/* Genlist */
			genlist = elm_genlist_add(grid);

			/*num_of_item = 3;
			for (i = 0; i < num_of_item; i++) {

				item_data_s *id = calloc(sizeof(item_data_s), 1);
				id->index = i;
				it = elm_genlist_item_append(list, itc,id,NULL, ELM_GENLIST_ITEM_NONE, NULL, id);
				id->item = it;
			}*/

			evas_object_size_hint_weight_set(genlist, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

			elm_grid_pack(grid, genlist, 30, 130, 420,500);


			elm_object_text_set(label_forpet, "<font_size=38><align=center><color=#000000>For Pet</align></font size></color>");
			elm_grid_pack(grid, label_forpet, 162, 730,150, 150);
			evas_object_show(label_forpet);
			btn = elm_button_add(grid);
				elm_object_style_set(btn, "icon_expand_add");
				 elm_grid_pack(grid, btn, 215, 655, 50, 50);
				 evas_object_smart_callback_add(btn, "clicked", make_popup_time,nf);
				elm_genlist_realized_items_update(genlist);
				evas_object_show(genlist);
				evas_object_show(btn);

			return grid;
   }



void feeding_view_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *scroller,*layout;
	Evas_Object *nf = data;
	scroller = elm_scroller_add(nf);
	layout = create_button_view(scroller,nf);
	elm_object_content_set(scroller, layout);
	//elm_naviframe_item_push(nf, NULL, NULL, NULL, scroller, NULL);
	Elm_Object_Item *nf_it = elm_naviframe_item_push(nf,NULL, NULL, NULL,scroller, NULL);
	elm_naviframe_item_title_enabled_set(nf_it,EINA_FALSE,EINA_FALSE);
	//elm_object_content_set(nf_it,nf);
	 elm_object_item_data_set(nf_it, nf);

	evas_object_show(nf);

}

