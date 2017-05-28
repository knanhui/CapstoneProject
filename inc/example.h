#ifndef __example_H__
#define __example_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>



#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "example"

#if !defined(PACKAGE)
#define PACKAGE "org.example.example"
#endif
void diary_view_cb(void *data, Evas_Object *obj, void *event_info);
void statistics_view_cb(void *data, Evas_Object *obj, void *event_info);
void feeding_view_cb(void *data, Evas_Object *obj, void *event_info);
void setting_view_cb(void *data, Evas_Object *obj, void *event_info);
void btn_back_cb(void *data, Evas_Object *obj, void *event_info);
void app_get_resource(const char *res_file_in, char *res_path_out, int res_path_max);
#endif /* __example_H__ */
