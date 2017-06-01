#include "example.h"
#include "custombutton.h"
#include <sqlite3.h>
#include <stdlib.h>


typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
	Evas_Object *grid_main;
	Evas_Object *img ;
	Evas_Object *btn;
	Evas_Object *nf;
	Elm_Object_Item *nf_it;

	Evas_Object *list;
	Evas_Object * scroller;
	// Database handle
	char *current_key;
} appdata_s;


win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	ui_app_exit();
}

static void
win_back_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}


void app_get_resource(const char *res_file_in, char *res_path_out, int res_path_max)
{
    char *res_path = app_get_resource_path();
    if (res_path)
    {
    	snprintf(res_path_out, res_path_max, "%s%s", res_path, res_file_in);
    	free(res_path);
    }
}




static Eina_Bool naviframe_pop_cb(void *data, Elm_Object_Item *it)
{
	ui_app_exit();
	return EINA_FALSE;
}


static void
create_base_gui(appdata_s *ad)
{
	/* Window */
	/* Create and initialize elm_win.
	   elm_win is mandatory to manipulate window. */
	char img_path[PATH_MAX] = "";

	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(ad->win, EINA_TRUE);


	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win, (const int *)(&rots), 4);
	}

	evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);
	//eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb, ad);

	/* Conformant */
	/* Create and initialize elm_conformant.
	   elm_conformant is mandatory for base gui to have proper size
	   when indicator or virtual keypad is visible. */
	ad->conform = elm_conformant_add(ad->win);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
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
	elm_object_content_set(ad->conform,ad->nf);

	evas_object_show(ad->nf);

	ad->grid_main = elm_grid_add(ad->nf);

	elm_grid_size_set(ad->grid_main, 480, 800);
	evas_object_size_hint_weight_set(ad->grid_main, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(ad->grid_main);


	ad->nf_it = elm_naviframe_item_push(ad->nf,NULL, NULL, NULL, ad->grid_main, NULL);
	elm_naviframe_item_title_enabled_set(ad->nf_it,EINA_FALSE,EINA_FALSE);


//	eext_object_event_callback_add(ad->nf, EEXT_CALLBACK_BACK, eext_naviframe_back_cb, NULL);
	//elm_naviframe_item_pop_cb_set(ad->nf_it, naviframe_pop_cb,ad->grid_main);
	eext_object_event_callback_add(ad->nf, EEXT_CALLBACK_BACK, eext_naviframe_back_cb, NULL);
	elm_naviframe_item_pop_cb_set(ad->nf_it, naviframe_pop_cb, ad->win);
	//evas_object_show(ad->grid_main);
	Evas_Object *bg = elm_bg_add(ad->conform);
	elm_grid_pack(ad->grid_main, bg, 0, 0, 480, 800);
	elm_bg_color_set(bg, 255, 255, 255);
	evas_object_show(bg);


	/*label*/
	ad->label = elm_label_add(ad->grid_main);
	Evas_Object *rect = evas_object_rectangle_add(ad->grid_main);
	evas_object_color_set(rect, 0, 204, 153, 255);
	elm_grid_pack(ad->grid_main, rect, 0, 0, 480, 80);
	evas_object_show(rect);
	elm_object_text_set(ad->label, "<font_size=80><align=center><color=#ffffff>For Pet</align></font size></color>");
	elm_grid_pack(ad->grid_main, ad->label, 100, 10, 300, 150);

	evas_object_show(ad->label);



	/*image*/

	app_get_resource("2.png", img_path, PATH_MAX);
	ad->img= evas_object_image_filled_add(ad->grid_main);
	evas_object_image_file_set(ad->img, img_path, NULL);
	elm_grid_pack(ad->grid_main, ad->img, 15, 200, 450, 480);
	evas_object_show(ad->img);





	/* Custom Button-1 */
    /* Canvas */
	Evas* canvas = evas_object_evas_get(ad->conform);

	ad->scroller=elm_scroller_add(ad->nf);

	//Evas_Object * m_bd1 = create_rect_set(canvas, ad->grid_main, 25,380, 80, 80);
//	m_bd1=create_text_set(canvas,ad->grid_main,25,380,80,80,"일지",NULL);
	buttondata_s* m_bd1 = create_button(canvas, ad->grid_main, 25,380, 80, 80, "일지",NULL);
	evas_object_event_callback_add (m_bd1->text, EVAS_CALLBACK_MOUSE_DOWN, diary_view_cb, ad->nf);
	buttondata_s* m_bd2=create_button(canvas, ad->grid_main, 98,292, 80, 80, "통계", NULL);
	evas_object_event_callback_add (m_bd2->text, EVAS_CALLBACK_MOUSE_DOWN, statistics_view_cb, ad->nf);
	buttondata_s* m_bd3=create_button(canvas, ad->grid_main, 202,245, 80, 80, "바로<br>주기", NULL);
	//evas_object_event_callback_add (m_bd3->text, EVAS_CALLBACK_MOUSE_DOWN, feeding_view_cb, ad->nf);
	buttondata_s* m_bd4=create_button(canvas, ad->grid_main, 304,295, 80, 80, "배식<br>관리", NULL);
	evas_object_event_callback_add (m_bd4->text, EVAS_CALLBACK_MOUSE_DOWN, feeding_view_cb, ad->nf);
	buttondata_s* m_bd5=create_button(canvas, ad->grid_main, 367,395, 80, 80, "설정", NULL);
	evas_object_event_callback_add (m_bd5->text, EVAS_CALLBACK_MOUSE_DOWN, setting_view_cb,ad->nf);
	//evas_object_smart_callback_add(m_bd5->text, "clicked",setting_view_cb,ad);

	//appdata_s *temp = getAppdata();
	evas_object_show(ad->grid_main);


	evas_object_show(ad->win);
}


static bool
app_create(void *data)
{
	/* Hook to take necessary actions before main event loop starts
		Initialize UI resources and application's data
		If this function returns true, the main loop of application starts
		If this function returns false, the application is terminated */
	appdata_s *ad = data;

	create_base_gui(ad);

	return true;
}

static void
app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}

static void
app_pause(void *data)
{
	/* Take necessary actions when application becomes invisible. */
}

static void
app_resume(void *data)
{
	/* Take necessary actions when application becomes visible. */
}

static void
app_terminate(void *data)
{
	/* Release all resources. */
}

static void
ui_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/

	int ret;
	char *language;

	ret = app_event_get_language(event_info, &language);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_event_get_language() failed. Err = %d.", ret);
		return;
	}

	if (language != NULL) {
		elm_language_set(language);
		free(language);
	}
}

static void
ui_app_orient_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void
ui_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void
ui_app_low_battery(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_BATTERY*/
}

static void
ui_app_low_memory(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_MEMORY*/
}

int
main(int argc, char *argv[])
{
	appdata_s ad = {0,};
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = {0,};
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}

	return ret;
}
