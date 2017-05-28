/*
 * CustomButton.h
 *
 *  Created on: Apr 1, 2017
 *      Author: KimYuJeong
 */

#ifndef CUSTOMBUTTON_H_
#define CUSTOMBUTTON_H_
typedef struct buttondata
{
	Evas_Object *rect;
	Evas_Object *text;
}
buttondata_s;

Evas_Object*
create_rect(Evas* canvas, Evas_Object* grid, int x, int y, int w, int h, int r, int g, int b, int a)
{
	Evas_Object *rect = evas_object_rectangle_add(canvas);
	evas_object_color_set(rect, r, g, b, a);
	elm_grid_pack(grid, rect, x, y, w, h);
	evas_object_show(rect);
	return rect;
}
Evas_Object*
create_textblock(Evas* canvas, Evas_Object* grid, Evas_Coord x, Evas_Coord y, Evas_Coord w, Evas_Coord h, const char* str){
	Evas_Object *textblock = evas_object_textblock_add(canvas);
		elm_grid_pack(grid, textblock, x, y, w, h);

	    Evas_Textblock_Style *st = evas_textblock_style_new();
	    evas_textblock_style_set(st, "DEFAULT='font=Sans font_size=40 color=#00CC99 wrap=mixed align=center'");
	    evas_object_textblock_style_set(textblock, st);
	    evas_textblock_style_free(st);
	    evas_object_textblock_valign_set(textblock, 0.5);
	    evas_object_textblock_text_markup_set(textblock, str);
	    evas_object_show(textblock);

	    return textblock;
}




buttondata_s*
//Evas_Object*
create_button(Evas* canvas, Evas_Object* grid, Evas_Coord x, Evas_Coord y, Evas_Coord w, Evas_Coord h,const char* str, Evas_Object_Event_Cb func)
{
	buttondata_s* bd = (buttondata_s*)malloc( sizeof( buttondata_s) );
	/* Rectangle */
	bd->rect = create_rect(canvas, grid, x, y, w, h, 0, 0, 0, 0);
	bd->text = create_textblock(canvas,grid,x,y,w,h,str);
	 evas_object_event_callback_add( bd->text, EVAS_CALLBACK_MOUSE_UP, func, (void*)bd);
	return bd;

}


void set_button_text(buttondata_s* bd, const char* str)
{
	evas_object_textblock_text_markup_set(bd->text, str);
	evas_object_show(bd->text);
}
#endif /* CUSTOMBUTTON_H_ */
