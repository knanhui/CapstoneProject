#include "HX711.h"

#include <Debug.h>

#include <JSN270.h>

#include <Arduino.h>

#include <SoftwareSerial.h>

#include <Servo.h>



#define SSID      "UCLAB"      // your wifi network SSID
#define KEY       "uclab2006"      // your wifi network password
#define AUTH       "WPA2"       // your wifi network security (NONE, WEP, WPA, WPA2)



#define calibration_factor -99700

#define DOUT  11

#define CLK  12



#define USE_DHCP_IP 1



#if !USE_DHCP_IP

#define MY_IP          "192.168.1.133"

#define SUBNET         "255.255.255.0"

#define GATEWAY        "192.168.1.254"

#endif



#define SERVER_PORT    8888

#define PROTOCOL       "UDP"



SoftwareSerial mySerial(3, 2); // RX, TX

Servo servo;

HX711 scale(DOUT, CLK);

JSN270 JSN270(&mySerial);



int servo_Pin=9;

int min_value=544;

int max_value=2400;

int Liquid_level=0;

void setup() {

  char c;



  mySerial.begin(9600);

  Serial.begin(9600);



  Serial.println("--------- JSN270 UDP Server with WPA Test --------");



  // wait for initilization of JSN270

  delay(5000);

  //JSN270.reset();

  delay(1000);



  //JSN270.prompt();

  JSN270.sendCommand("at+ver\r");

  delay(5);

  while(JSN270.receive((uint8_t *)&c, 1, 1000) > 0) {

    Serial.print((char)c);

  }

  delay(1000);



#if USE_DHCP_IP

  JSN270.dynamicIP();

#else

  JSN270.staticIP(MY_IP, SUBNET, GATEWAY);

#endif    

    

  if (JSN270.join(SSID, KEY, AUTH)) {

    Serial.println("WiFi connect to " SSID);

  }

  else {

    Serial.println("Failed WiFi connect to " SSID);

    Serial.println("Restart System");



    return;

  }

  delay(1000);



  JSN270.sendCommand("at+wstat\r");

  delay(5);

  while(JSN270.receive((uint8_t *)&c, 1, 1000) > 0) {

    Serial.print((char)c);

  }

  delay(1000);        



  JSN270.sendCommand("at+nstat\r");

  delay(5);

  while(JSN270.receive((uint8_t *)&c, 1, 1000) > 0) {

    Serial.print((char)c);

  }

  delay(1000);



  if (!JSN270.server(SERVER_PORT, PROTOCOL)) {

    Serial.println("Failed connect ");

    Serial.println("Restart System");

  } else {

    Serial.println("Waiting for connection...");

    delay(1000);



    // Enter data mode

    JSN270.sendCommand("at+exit\r");

    delay(5);

  }



   pinMode(5,INPUT);

   servo.attach(servo_Pin,min_value,max_value);

   servo.write(90);



   scale.set_scale(calibration_factor); //This value is obtained by using the SparkFun_HX711_Calibration sketch

   //scale.tare();  //Assuming there is no weight on the scale at start up, reset the scale to 0



}



void loop() {

  static int count = 0;

  static int waterCheck = 0; //Previous

  static int feedCheck = 0; //Current

  int gram = 453.592*scale.get_units() - 32 - 758 - 75 - 27586;



  int servo_value;

  if(JSN270.available()) {

    char c = (char)JSN270.read();

    Serial.println(c);

    //모터 돌리기

    if(c == 'm'){
      Serial.println("receive");

    if((count % 2) == 0){

      servo_value = 0;

         servo.write(servo_value);

       Serial.println(servo_value);

    }
    else{

      servo_value = 180;

      servo.write(servo_value);

       Serial.println(servo_value);

    }

    count++;

    }

  }


  if(Serial.available()) {

    JSN270.print((char)Serial.read());


  }


  delay(1000);

}
