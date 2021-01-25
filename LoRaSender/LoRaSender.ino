// Librairies nécessaires pour utiliser les capteurs de température
#include <OneWire.h> 
#include <DallasTemperature.h> 

// Librairies nécessaires pour utiliser le module LoRa
#include <SPI.h>
#include <LoRa.h> 

// Data wire is plugged into digital pin 2 on the Arduino 
#define ONE_WIRE_BUS  4 

//define the pins used by the transceiver module
#define ss 10
#define rst 9
#define dio0 2
#define LONGEUR_TRAME 12  

// Setup a oneWire instance to communicate with any OneWire device 
OneWire oneWire(ONE_WIRE_BUS);     

// Pass oneWire reference to DallasTemperature library 
DallasTemperature sensors(&oneWire); 

int deviceCount = 0; // Nombre de capteurs connectés
float tempC; // tempon pour les températures en oC
String str = "";

void setup(void) 
{ 
  sensors.begin();    // Start up the library for the sensor
  //initialize Serial Monitor
  Serial.begin(115200);
  while (!Serial);
  Serial.println("LoRa Sender"); 

  //setup LoRa transceiver module
  LoRa.setPins(ss, rst, dio0);

  //replace the LoRa.begin(---E-) argument with your location's frequency 
  //433E6 for Asia
  //866E6 for Europe
  //915E6 for North America
  while (!LoRa.begin(915E6)) {
    Serial.println(".");
    delay(500);
  }
  // Change sync word (0xF3) to match the receiver
  // The sync word assures you don't get LoRa messages from other LoRa transceivers
  // ranges from 0-0xFF
  LoRa.setSyncWord(0xF3);
  Serial.println("LoRa Initializing OK!");
  
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

  // Display temperature from each sensor 
  for (int i = 0;  i < deviceCount;  i++) 
  { 
    str = "Sensor " + String(i) + " : " + String(sensors.getTempCByIndex(i))+ "oC";
    Serial.print("Sending packet: ");
    Serial.println(str);
    //Send LoRa packet to receiver
    LoRa.beginPacket();
    LoRa.print(str);
    LoRa.endPacket();
    str = "";
  } 
  delay(1000);
} 
