#include <stdio.h>
#include <string.h>
#include <sys/socket.h>
#include <arpa/inet.h>
#include <sys/stat.h>
#include <unistd.h>
#include "example.h"
int socket_desc;
#define  BUFF_SIZE   1024

void manual_view_cb(void *data, Evas_Object *obj, void *event_info){
	   struct sockaddr_in server;
		    char *message;
		    char buff[BUFF_SIZE];
		    //Create socket
		    socket_desc = socket(AF_INET , SOCK_STREAM , 0);
		    if (socket_desc == -1)
		    {
		        printf("Could not create socket");
		    }

		    server.sin_addr.s_addr = inet_addr("35.185.149.161");
		    server.sin_family = AF_INET;
		    server.sin_port = htons( 80 );

		    //Connect to remote server
		    if (connect(socket_desc , (struct sockaddr *)&server , sizeof(server)) < 0)
		    {
		    	dlog_print(DLOG_INFO, LOG_TAG, "connect fail");
		    }

		    //Send some data
		    message = "send";
		    if( send(socket_desc , message , strlen(message) , 0) < 0)
		    {
		    	dlog_print(DLOG_INFO, LOG_TAG, "fail send");
		    }
		    dlog_print(DLOG_INFO, LOG_TAG, message);

		    close(socket_desc);
}
