/*
 * datab.h
 *
 *  Created on: Jun 2, 2017
 *      Author: KimYuJeong
 */

#ifndef DATAB_H_
#define DATAB_H_

typedef struct item_data {
	int index;
	Elm_Object_Item *item;
	 sqlite3 *db;
	 Eina_Bool check_w;
	 Eina_Bool check_f;
} item_data_s;

item_data_s * id;

#endif /* DATAB_H_ */
