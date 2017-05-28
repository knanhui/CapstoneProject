/*
 * datetime.h
 *
 *  Created on: May 10, 2017
 *      Author: KimYuJeong
 */

#ifndef DATETIME_H_
#define DATETIME_H_

#include <utils_i18n.h>
typedef struct timedata
{
	 char *tzid;
	 i18n_ucalendar_h ucal;
	  i18n_udate udate;
}
timedata_s ;
static int numOfitem=0;

static i18n_ucalendar_h
create_time(char *tzid) {
	i18n_ucalendar_h ucal;
	i18n_uchar *_tzid = (i18n_uchar*)calloc(strlen(tzid) + 1, sizeof(i18n_uchar));
    i18n_ustring_copy_ua(_tzid, tzid);
    int len = i18n_ustring_get_length(_tzid);
    int ret = i18n_ucalendar_create(_tzid, len, "ko_KR", I18N_UCALENDAR_TRADITIONAL, &ucal);
    if (ret != 0)
    {
    	dlog_print(DLOG_ERROR, LOG_TAG, "i18n_ucalendar_create() failed with err = %d", ret);
    	return NULL;
    }


    return ucal;
}
static void set_numOfitem(){
	numOfitem++;
}
static int get_numOfitem(){
	return numOfitem;
}

static char* time2string(i18n_ucalendar_h ucal)
{
	int year, month, day, hour, minute, second;
	  i18n_udate udate;
	   i18n_ucalendar_get_now(&udate);
	   i18n_ucalendar_set_milliseconds(ucal, udate);
	i18n_ucalendar_get(ucal, I18N_UCALENDAR_YEAR, &year);
	i18n_ucalendar_get(ucal, I18N_UCALENDAR_MONTH, &month);
	i18n_ucalendar_get(ucal, I18N_UCALENDAR_DATE, &day);
	//i18n_ucalendar_get(ucal, I18N_UCALENDAR_HOUR, &hour);
	//i18n_ucalendar_get(ucal, I18N_UCALENDAR_MINUTE, &minute);
	//i18n_ucalendar_get(ucal, I18N_UCALENDAR_SECOND, &second);
	char *buf = malloc(100);
	sprintf(buf, "%sNow :%04d-%02d-%02d%s", "<font_size=58>",year, month + 1, day,"</font_size>");
	//sprintf(buf, "Now :%04d-%02d-%02d", year, month + 1, day);
//	snprintf(buf, sizeof(buf), "%s%d%s", , buf, "</font_size>");
	return buf;
    }
static int getMonth(){
	char *tzid;
	int month;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_TIMEZONE,tzid);
	i18n_ucalendar_h ucal = create_time(tzid);
	i18n_ucalendar_get(ucal, I18N_UCALENDAR_MONTH, &month);
	return month;
}
static char * getDate(){
	char *tzid;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_TIMEZONE,tzid);
	i18n_ucalendar_h ucal = create_time(tzid);

	 //update(ad);
	char *buf = time2string(ucal);
	return buf;

}


#endif /* DATETIME_H_ */
