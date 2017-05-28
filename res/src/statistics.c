#include "example.h"
static Evas_Object* create_button_view(Evas_Object *parent,Evas_Object *nf)
{
	Evas_Object *btn, *img, *grid,*label;
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
	Evas_Object *rect = evas_object_rectangle_add(grid);
	evas_object_color_set(rect, 0, 204, 153, 255);
	elm_grid_pack(grid, rect, 0, 0, 480, 80);
	evas_object_show(rect);
	elm_object_text_set(label, "<font_size=80><align=center><color=#ffffff>STATISTICS</align></font size></color>");

	elm_grid_pack(grid, label, 100, 10, 300, 150);
    //evas_object_smart_callback_add(btn, "clicked", btn_back_cb, nf);
    evas_object_event_callback_add (label, EVAS_CALLBACK_MOUSE_DOWN, btn_back_cb,nf);
	evas_object_show(label);

	    return grid;
   }

void statistics_view_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *scroller, *layout;
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

