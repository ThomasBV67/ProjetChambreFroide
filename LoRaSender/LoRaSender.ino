/*
  LoRaSender
  Ce programme permet à un arduino, connecté à un module LoRa, d'envoyer les valeurs de tous les capteurs connectés à celui-ci
  via un lien LoRa.
 
  modifié le 25 janvier 2021
  par Thomas Bureau-Viens
 */
//********************** Section des Includes **********************//
// Librairies nécessaires pour utiliser les capteurs de température
#include <OneWire.h> 
#include <DallasTemperature.h> 

// Librairies nécessaires pour utiliser le module LoRa
#include <SPI.h>
#include <LoRa.h> 


//********************** Section des Defines **********************//
// Data wire is plugged into digital pin 2 on the Arduino 
#define ONE_WIRE_BUS  4 

//define the pins used by the transceiver module
#define ss 10
#define rst 9
#define dio0 2
#define LONGEUR_TRAME 12  


//****** Section des Instenciations de variables et d'objets ******//
// Setup a oneWire instance to communicate with any OneWire device 
OneWire oneWire(ONE_WIRE_BUS);     

// Pass oneWire reference to DallasTemperature library 
DallasTemperature sensors(&oneWire); 

// Référence pour avoir acces aux adresses des capteurs
DeviceAddress Thermometer; 

// Instenciation de variables
int deviceCount = 0; // Nombre de capteurs connectés
float tempC; // tempon pour les températures en oC
String str = ""; // Tempon pour le texte à envoyer


void setup(void) 
{ 
  // Initialisation de la communication série //
  Serial.begin(115200);
  while (!Serial);
  Serial.println("LoRa Sender"); 


  // Initialisation de la communication LoRa //
  LoRa.setPins(ss, rst, dio0);
  while (!LoRa.begin(915E6)) // 915E6 pour la fréquence d'amérique du nord
  {
    Serial.println(".");
    delay(500);
  }
  // Change sync word (0xF3) to match the receiver
  // The sync word assures you don't get LoRa messages from other LoRa transceivers
  // ranges from 0-0xFF
  LoRa.setSyncWord(0x45);
  Serial.println("LoRa Initializing OK!");

  
  // Initialisation des capteurs de température //
  sensors.begin();    // Start up the library for the sensor
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
    sensors.getAddress(Thermometer, i); 
    str = "Sensor " + String(i) + " : " + String(sensors.getTempCByIndex(i))+ "oC, ";
    for(int j=0; j<=7; j++)
    {
      str = str + String(Thermometer[j]); 
      if(j<7)
      {
        str = str + "-";
      }
      
    }
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
