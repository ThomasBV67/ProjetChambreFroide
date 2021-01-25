#include <OneWire.h> 
#include <DallasTemperature.h> 

// Data wire is plugged into digital pin 12 on the Arduino 
#define ONE_WIRE_BUS 4 


// Setup a oneWire instance to communicate with any OneWire device 
OneWire oneWire(ONE_WIRE_BUS);     


// Pass oneWire reference to DallasTemperature library 
DallasTemperature sensors(&oneWire); 


// variable to hold device addresses 
DeviceAddress Thermometer;   

// Variables globales
int g_deviceCount = 0; 
int g_checkSum = 0;
float g_tempC; 

void setup(void) 
{ 
  sensors.begin();    // Start up the library 

  Serial.begin(115200);
  while (!Serial);
  Serial.println("LoRa Receiver"); 
   
  sensors.setResolution(12); // Résolution maximale

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
  
  g_deviceCount = sensors.getDeviceCount(); // Get le nombre de capteurs branchés
} 

void loop(void) 

{  
  char tempEntier, tempDecimal;
  unsigned char address[8];
  String tempon;
  byte trame[12] = {};
  
  // Send command to all the sensors for temperature conversion 
  sensors.requestTemperatures();  

  // Display temperature from each sensor 

  for (int i = 0;  i < g_deviceCount;  i++) // Loop qui passe par chaque capteur
  { 
    sensors.getAddress(Thermometer, i); // Get l'address du capteur courant
    g_tempC = sensors.getTempCByIndex(i); // get la température 
    
    tempEntier = (char)g_tempC;
    tempDecimal = (g_tempC-tempEntier)*100;
    
    trame[0] = 0x01;
    
    for(int i = 0; i<8; i++)
    {
      trame[i+1] = Thermometer[i];
      g_checkSum = g_checkSum + Thermometer[i];
    }
    
    trame[9]=(byte)tempEntier; 
    g_checkSum += tempEntier;
    trame[10] = (byte)tempDecimal; 
    g_checkSum += tempDecimal;
    trame[11] = g_checkSum%0x100;
    
    for(int j = 0; j<12 ; j++)
    {
      Serial.println(trame[j]);
    }
    
  } 
  delay(2000); 

} 
