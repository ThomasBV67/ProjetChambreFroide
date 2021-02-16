/*
  getAdressesCapteurs
  Ce programme permet à un arduino, connecté à un ou des capteurs de température DS18B20, d'afficher
  l'adresse de chaque capteur connecté à celui-ci sur le port série.
 
  modifié le 25 janvier 2021
  par Thomas Bureau-Viens
 */
#include <OneWire.h> 
#include <DallasTemperature.h> 

// Data wire is plugged into port 2 on the Arduino 

#define ONE_WIRE_BUS 4

  

// Setup a oneWire instance to communicate with any OneWire devices 

OneWire oneWire(ONE_WIRE_BUS); 

  

// Pass our oneWire reference to Dallas Temperature. 

DallasTemperature sensors(&oneWire); 

  

// variable to hold device addresses 

DeviceAddress Thermometer; 

  

int deviceCount = 0; 

  

void setup(void) 

{ 

  // start serial port 

  Serial.begin(9600); 

  

  // Start up the library 

  sensors.begin(); 

  

  // locate devices on the bus 

  Serial.println("Locating devices..."); 

  Serial.print("Found "); 

  deviceCount = sensors.getDeviceCount(); 

  Serial.print(deviceCount, DEC); 

  Serial.println(" devices."); 

  Serial.println(""); 

   
  // Print les adresses sur le port série
  Serial.println("Printing addresses..."); 

  for (int i = 0;  i < deviceCount;  i++) 

  { 

    Serial.print("Sensor "); 

    Serial.print(i+1); 

    Serial.print(" : "); 

    sensors.getAddress(Thermometer, i); 

    printAddress(Thermometer); 

  } 

} 

  
// rien dans le loop
void loop(void) 
{} 

  
/*
 * Cette fonction print en HEX chaque byte de l'adresse du capteur envoyé en parametre
 */
void printAddress(DeviceAddress deviceAddress) 

{  
  //Serial.println((int)deviceAddress, HEX);

  for (uint8_t i = 0; i < 8; i++) 

  { 

    Serial.print("0x"); 

    if (deviceAddress[i] < 0x10) Serial.print("0"); 

    Serial.print(deviceAddress[i], HEX); 

    if (i < 7) Serial.print(", "); 

  } 

  Serial.println(""); 

} 
