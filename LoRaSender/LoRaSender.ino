#include <OneWire.h> 

#include <DallasTemperature.h> 

#include <>  

// Data wire is plugged into digital pin 2 on the Arduino 

#define ONE_WIRE_BUS  2 

#define LONGEUR_TRAME 12  

// Setup a oneWire instance to communicate with any OneWire device 

OneWire oneWire(ONE_WIRE_BUS);     

  

// Pass oneWire reference to DallasTemperature library 

DallasTemperature sensors(&oneWire); 

  

int deviceCount = 0; 

float tempC; 

  

void setup(void) 

{ 

  sensors.begin();    // Start up the library 

  Serial.begin(9600); 

   

  // locate devices on the bus 

  Serial.print("Locating devices..."); 

  Serial.print("Found "); 

  deviceCount = sensors.getDeviceCount(); 

  Serial.print(deviceCount, DEC); 

  Serial.println(" devices."); 

  Serial.println(""); 

} 

  

void loop(void) 

{  

  // Send command to all the sensors for temperature conversion 

  sensors.requestTemperatures();  
  
  byte [LONGEUR_TRAME] trame; // trame : SOH, idModule x8, dataEntier, dataDecimal, checkSum
   

  // Display temperature from each sensor 

  for (int i = 0;  i < deviceCount;  i++) 

  { 
    tempC = sensors.getTempCByIndex(i);
    

  } 

   

  Serial.println(""); 

  delay(1000); 

} 
