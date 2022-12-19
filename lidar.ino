
//Sensor

#include<SoftwareSerial.h>// soft serial port header file
SoftwareSerial Serial1(8,9); // define the soft serial port as Serial1, pin2 as RX, and pin3 as TX
/*For Arduino board with multiple serial ports such as DUE board, comment out the above two codes, and directly use
Serial1 port*/
int dist;// LiDAR actually measured distance value
int strength;// LiDAR signal strength
int check;// check numerical value storage
int i;
int uart[9];// store data measured by LiDAR
const int HEADER=0x59;// data package frame header

byte byte0_input;
byte byte1_input; 
byte byte2_input; 
boolean stateData = false;
float scanRoom()
{
  if (Serial1.available())
  {
    if(Serial1.read()==HEADER)
    {
      uart[0]=HEADER;
      if(Serial1.read()==HEADER)
      {
        uart[1]=HEADER;
        for(i=2;i<9;i++)
        {
          uart[i]=Serial1.read();
        }
        check=uart[0]+uart[1]+uart[2]+uart[3]+uart[4]+uart[5]+uart[6]+uart[7];
        
        if(uart[8]==(check&0xff))// check the received data as per protocols
        {
          dist=uart[2]+uart[3]*256;// calculate distance value
          strength=uart[4]+uart[5]*256;
          float distance = dist/100.; //
          return distance ; 
        }
      }
    }
  }
  return -1.0;
}


void startCommunication(float distance, int pos)
{

    byte0_input = 0;
    byte1_input = 0;
    byte2_input = 0;
    String str;
    if(Serial.available())
    {
      str = Serial.readStringUntil('\n');
    }

    if(str.length() < 3)
      return;

    if(str[0] == 4)
    {      

       switch (str[1]) 
       {
          case 8:
             //Set PIN and value
             switch (str[2])
            {
              case 8:
                 pos = 0;
                 stateData = false;
                 break;
              
              case 16:
                Serial.print("\nhandshake\n");
                
                break;
              case 32:
                  stateData = true;

                  break;
            }
        } 
  }
}


//step motor
#include <Stepper.h>

int angle = 360.0 / 1.7;

const int stepPin = 3;
const int dirPin = 4;
int position_angle= 0 ;
float distance;
int dir =0;
void setup() 
{
  
  pinMode(3,OUTPUT);
  pinMode(4,OUTPUT);
  
  Serial.begin(9600);//set the Baud rate of Arduino and computer serial port
  Serial1.begin(115200);//set the Baud rate of LiDAR and Arduino serial port
}

void loop() 
{
  
  startCommunication(distance,position_angle);
  
  if(stateData == true)
  {
    do
    {
      distance = scanRoom();
    } while( distance < 0.0 );
  
      Serial.print(distance);
      Serial.print("i");
      Serial.print(position_angle);
      Serial.print("i\n");
    //Serial.print("handshake\n"); return;
    if( dir == 0 )
    {
      digitalWrite(dirPin,HIGH);
    }
    else
    {
      digitalWrite(dirPin,LOW);
    }
    delay(10);
    digitalWrite(stepPin,HIGH);
    delay(10);
    digitalWrite(stepPin,LOW);
    delay(10);
    
    if(position_angle == 800)
    {
        dir = 1;
    }
    else if( position_angle == 0)
    {
       dir = 0;
    }
  
    if( dir == 0 )
    {
      position_angle++;
    }
    else
    {
      position_angle--;
    }
  } 
}
