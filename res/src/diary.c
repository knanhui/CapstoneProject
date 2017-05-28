#include "example.h"
//#include "CustomButton.h"
#include "datetime.h"
#include <dlog.h>
#include<json-glib/json-glib.h>
//#include"httprequest.h"
#include<curl/curl.h>
#include<json-glib-1.0/json-glib/json-reader.h>

typedef struct MemoryStruct{
   char *memory;
   size_t size;
}memoryStruct;

typedef struct appdata{
   Evas_Object *win;
   Evas_Object *conform;
   Evas_Object *label;
   Evas_Object *entry;
   Evas_Object *icon;
   memoryStruct ms;
}appdata_s;


Evas_Object *cal;
time_t current_time;

int current_month;
int pre_month;

static size_t write_memory_cb(void *contents, size_t size, size_t nmemb, void *userp){
   size_t realsize = size*nmemb;
   memoryStruct *mem = (memoryStruct *)userp;

   mem-> memory = realloc(mem->memory,mem->size + realsize+1);
   if(mem->memory == NULL){
      dlog_print(DLOG_INFO,"tag","not enough memory");
      return 0;
   }

   memcpy(&(mem->memory[mem->size]),contents,realsize);
   mem->size += realsize;
   mem->memory[mem->size] =0;
   return realsize;
}

void get_http_data(const char* url, memoryStruct *data){
   CURL *curl_handle;
   CURLcode res;

   data->memory = malloc(1);
   data->size =0;

   curl_global_init(CURL_GLOBAL_ALL);
   /* init the curl session */
   curl_handle = curl_easy_init();
   /* specify URL to get */
   curl_easy_setopt(curl_handle, CURLOPT_URL, url);
   /* send all data to this function */
   curl_easy_setopt(curl_handle, CURLOPT_WRITEFUNCTION, write_memory_cb);
   /* we pass our 'chunk' struct to the callback function */
   curl_easy_setopt(curl_handle, CURLOPT_WRITEDATA, (void *)data);
   /* some servers don't like requests that are made without a user-agent
   field, so we provide one */
   curl_easy_setopt(curl_handle, CURLOPT_USERAGENT, "libcurl-agent/1.0");
   /* get it! */
   res = curl_easy_perform(curl_handle);
   /* cleanup curl stuff */
   curl_easy_cleanup(curl_handle);
   /* we're done with libcurl, so clean it up */
   curl_global_cleanup();
}

static void btn_download_text(void *data, Evas_Object *obj, void *event_info){
   appdata_s *ad = data;
   char url[100] = {0};

   //sprintf(url,"https://35.185.149.161/index.php?data=10");
   sprintf(url,"http://api.openweathermap.org/data/2.5/weather?lat=37.498&lon=127.027&units=metric");
   get_http_data(url, &ad->ms);
   elm_object_text_set(ad->label, ad->ms.memory);
   free( ad->ms.memory);
}


void diary_option_view_cb(void *data, Evas_Object *obj, void *event_info);
void btn_back_cb(void *data, Evas_Object *obj, void *event_info)
{
   Evas_Object *nf = data;

   elm_naviframe_item_pop(nf);
}

void it0_view_cb(void *data, Evas_Object *obj, void *event_info){
   dlog_print(DLOG_INFO,LOG_TAG,"all!?");
    elm_object_text_set(obj,"<align=center>all</align>");

}

//view for feeding
void it1_view_cb(void *data, Evas_Object *obj, void *event_info){
   dlog_print(DLOG_INFO,LOG_TAG,"feeding!?");
    elm_object_text_set(obj,"<align=center>feeding</align>");

}


//view for hospital
void it2_view_cb(void *data, Evas_Object *obj, void *event_info){
   dlog_print(DLOG_INFO,LOG_TAG,"hospital!?");
   elm_object_text_set(obj,"<align=center>hospital</align>");
}

//view for walking
void it3_view_cb(void *data, Evas_Object *obj, void *event_info){
   dlog_print(DLOG_INFO,LOG_TAG,"walking!?");
   elm_object_text_set(obj,"<align=center>walking</align>");
}

//view for defecation
void it4_view_cb(void *data, Evas_Object *obj, void *event_info){
   dlog_print(DLOG_INFO,LOG_TAG,"defecation!?");
   elm_object_text_set(obj,"<align=center>defecation</align>");
}
void diary_create_view_cb(void *data,Evas_Object *obj, void *event_info);

static Evas_Object* diary_create_view(Evas_Object *parent,Evas_Object*nf){
   Evas_Object *grid;
   Evas_Object *label_feeding;
   Evas_Object *label_hospital;
   Evas_Object *label_walking;
   Evas_Object *label_defecation;
   Evas_Object *label;
   appdata_s *ad;

   grid= elm_grid_add(parent);
   elm_grid_size_set(grid,480,800);
   evas_object_size_hint_weight_set(grid, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
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

          elm_object_text_set(label, "<font_size=80><align=center><color=#ffffff>DIARY</align></font size></color>");
          elm_grid_pack(grid, label, 100, 10, 300, 150);
          //evas_object_event_callback_add (label, EVAS_CALLBACK_MOUSE_DOWN,diary_option_view_cb,nf);
          evas_object_show(label);

          label_feeding = elm_label_add(grid);
          label_hospital = elm_label_add(grid);
          label_walking = elm_label_add(grid);
          label_defecation = elm_label_add(grid);

          elm_object_text_set(label_feeding,"<align=center>feeding</align>");
          elm_object_text_set(label_hospital,"<align=center>hospital</align>");
          elm_object_text_set(label_walking,"<align=center>walking</align>");
          elm_object_text_set(label_defecation,"<align=center>defecation</align>");

          elm_grid_pack(grid,label_feeding,100,200,300,150);
          elm_grid_pack(grid,label_hospital,100,300,300,150);
          elm_grid_pack(grid,label_walking,100,400,300,150);
          elm_grid_pack(grid,label_defecation,100,500,300,150);

          evas_object_show(label_defecation);
          evas_object_show(label_hospital);
          evas_object_show(label_walking);
          evas_object_show(label_feeding);




   return grid;
}

static Evas_Object* create_option_view(Evas_Object *parent,Evas_Object*nf){
    Evas_Object *btn, *img, *grid,*label,*label2,*hoversel;
    Evas_Object *btn_plus;
    appdata_s *ad;
    char img_path[PATH_MAX] = "";
    //time_t current_time;
    struct tm stime;
    grid = elm_grid_add(parent);
    elm_grid_size_set(grid, 480, 800);
    evas_object_size_hint_weight_set(grid, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
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


        btn = elm_button_add(grid);
       elm_object_style_set(btn, "icon_expand_add");
        elm_grid_pack(grid, btn, 225, 730, 50, 50);
       //evas_object_show(btn);
       evas_object_event_callback_add (label, EVAS_CALLBACK_MOUSE_DOWN, btn_back_cb,nf);




          if (!elm_calendar_selected_time_get(cal, &stime)){
             return -1;
          }



            char *buf = malloc(100);
           sprintf(buf, "%s%04d-%02d-%02d%s", "<font_size=70><align=center><color=#ffffff>",stime.tm_year + 1900, stime.tm_mon + 1,  stime.tm_mday,"</align></font size></color>");
       elm_object_text_set(label,buf);
       dlog_print(DLOG_INFO, "user_tag", buf);
          elm_grid_pack(grid, label, 100, 10, 300, 150);

          // plus button initialize
           btn_plus = elm_button_add(grid);
                 elm_object_style_set(btn_plus,"icon_expand_add");
                 elm_grid_pack(grid,btn_plus,100,680,300,150);
                 evas_object_show(btn_plus);
                evas_object_event_callback_add (btn_plus, EVAS_CALLBACK_MOUSE_DOWN, diary_create_view_cb,nf);

       evas_object_show(label);
            /* Label*/
          label2 = elm_label_add(grid);
               elm_grid_pack(grid, label2, 80, 140,300, 300);
              evas_object_show(label2);
              hoversel = elm_hoversel_add(grid);
              elm_object_text_set(hoversel,"<align=center>option</align>");
              elm_hoversel_hover_begin(hoversel);
              elm_hoversel_hover_end(hoversel);

              //create option
              Eina_Bool expanded = elm_hoversel_expanded_get(hoversel);
              Elm_Object_Item *it0 = elm_hoversel_item_add(hoversel, "all",   NULL, ELM_ICON_NONE,it0_view_cb, NULL);
              Elm_Object_Item *it1 = elm_hoversel_item_add(hoversel, "feeding",   NULL, ELM_ICON_NONE,it1_view_cb, NULL); // Callback data
              Elm_Object_Item *it2 = elm_hoversel_item_add(hoversel, "hospital",   NULL, ELM_ICON_NONE, it2_view_cb, NULL);//병원
              Elm_Object_Item *it3 = elm_hoversel_item_add(hoversel, "walking",   NULL, ELM_ICON_NONE, it3_view_cb, NULL); //산책
              Elm_Object_Item *it4 = elm_hoversel_item_add(hoversel, "defecation",   NULL, ELM_ICON_NONE,it4_view_cb, NULL); //배변

              elm_grid_pack(grid, hoversel, 80, 120,350, 50);
              evas_object_show(hoversel);
              return grid;


}


static Evas_Object* create_button_view(Evas_Object *parent,Evas_Object *nf)
{
   Evas_Object *btn, *img, *grid,*label,*label2;



   char img_path[PATH_MAX] = "";
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
   elm_object_text_set(label, "<font_size=80><align=center><color=#ffffff>DIARY</align></font size></color>");
   elm_grid_pack(grid, label, 100, 10, 300, 150);

    btn = elm_button_add(grid);
   elm_object_style_set(btn, "icon_expand_add");
    elm_grid_pack(grid, btn, 225, 730, 50, 50);
   //evas_object_show(btn);
   evas_object_event_callback_add (label, EVAS_CALLBACK_MOUSE_DOWN, btn_back_cb,nf);

  // evas_object_event_callback_add (label, EVAS_CALLBACK_MOUSE_DOWN, btn_back_cb,nf);





   evas_object_show(label);
     /* Label*/
   label2 = elm_label_add(grid);

   char * buf=getDate();

    elm_object_text_set(label2,buf);
     elm_grid_pack(grid, label2, 80, 140,300, 300);
    evas_object_show(label2);
    cal = elm_calendar_add(grid);




   // evas_object_smart_callback_add(cal, "changed", create_option_view,nf);
    current_month=getMonth();
    pre_month=getMonth();
    evas_object_smart_callback_add(cal , "changed", diary_option_view_cb,nf);
     //elm_calendar_format_function_set(cal, _format_month_year);k

   elm_grid_pack(grid, cal, 40, 220,400, 400);
   evas_object_show(cal);


       return grid;
   }


void diary_view_cb(void *data, Evas_Object *obj, void *event_info)
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

void diary_create_view_cb(void *data,Evas_Object *obj, void *event_info){
   Evas_Object *scroller, *layout;
         Evas_Object *nf = data;

         scroller = elm_scroller_add(nf);
                  layout = diary_create_view(scroller,nf);

               elm_object_content_set(scroller, layout);
               //elm_naviframe_item_push(nf, NULL, NULL, NULL, scroller, NULL);
               Elm_Object_Item *nf_it = elm_naviframe_item_push(nf,NULL, NULL, NULL,scroller, NULL);
               elm_naviframe_item_title_enabled_set(nf_it,EINA_FALSE,EINA_FALSE);


               //elm_object_content_set(nf_it,nf);
                elm_object_item_data_set(nf_it, nf);
                evas_object_show(nf);


}
void diary_option_view_cb(void *data, Evas_Object *obj, void *event_info){

      Evas_Object *scroller, *layout;
      Evas_Object *nf = data;


      struct tm stime;

          if (!elm_calendar_selected_time_get(cal, &stime)){
             return ;
          }
      char *buf = malloc(100);



       sprintf(buf, "%s%02d-%02d%s", "current", current_month + 1, pre_month+1,"pre");
       dlog_print(DLOG_INFO, "user_tag", buf);
       current_month=stime.tm_mon;



      if(current_month!=pre_month){
                   pre_month =current_month;


                }
      else{
         scroller = elm_scroller_add(nf);
         layout = create_option_view(scroller,nf);

      elm_object_content_set(scroller, layout);
      //elm_naviframe_item_push(nf, NULL, NULL, NULL, scroller, NULL);
      Elm_Object_Item *nf_it = elm_naviframe_item_push(nf,NULL, NULL, NULL,scroller, NULL);
      elm_naviframe_item_title_enabled_set(nf_it,EINA_FALSE,EINA_FALSE);


      //elm_object_content_set(nf_it,nf);
       elm_object_item_data_set(nf_it, nf);
       evas_object_show(nf);
      }






}

