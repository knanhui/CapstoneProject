#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <arpa/inet.h>
#include <sys/types.h>
#include <sys/socket.h>
#include "example.h"

#define  BUFF_SIZE   1024

void manual_view_cb(void *data, Evas_Object *obj, void *event_info)
{
   int   sock;
   int   server_addr_size;
   struct sockaddr_in   server_addr;
   char   buff_rcv[BUFF_SIZE+5];
   char *message;

   sock  = socket( PF_INET, SOCK_DGRAM, 0);

   if( -1 == sock)
   {
      printf( "socket 생성 실패n");
      exit( 1);
   }
   message = "m";

   memset( &server_addr, 0, sizeof( server_addr));
   server_addr.sin_family     = AF_INET;
   server_addr.sin_port       = htons(8888);
   server_addr.sin_addr.s_addr= inet_addr("192.168.43.11");

   sendto( sock, message, strlen(message)+1, 0, ( struct sockaddr*)&server_addr, sizeof( server_addr));


   dlog_print(DLOG_INFO, LOG_TAG, message);

/*?
   server_addr_size  = sizeof( server_addr);
   if(recvfrom( sock, buff_rcv, BUFF_SIZE, 0 ,
           ( struct sockaddr*)&server_addr, &server_addr_size) < 0){
	   dlog_print(DLOG_INFO, LOG_TAG, "receive error");
  }

   dlog_print(DLOG_INFO, LOG_TAG, buff_rcv);
*/
   close( sock);


}
