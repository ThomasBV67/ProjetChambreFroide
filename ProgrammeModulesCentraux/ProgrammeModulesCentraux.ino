#include <OneWire.h> 

#include <DallasTemperature.h> 

#include <SPI.h>
#include <LoRa.h>

String NUM_MODULE = "1";

//define the pins used by the transceiver module
#define ss 10
#define rst 9
#define dio0 2
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
  Serial.begin(115200); 
  Serial.println("Setup...");
  // Start up the library 
  sensors.begin(); 

    LoRa.setPins(ss, rst, dio0);
  
  //replace the LoRa.begin(---E-) argument with your location's frequency 
  //433E6 for Asia
  //866E6 for Europe
  //915E6 for North America
  while (!LoRa.begin(915E6)) {
    Serial.println(".");
    delay(500);
  }
  LoRa.setSyncWord(0x45);
  deviceCount = sensors.getDeviceCount(); 
} 

  

void loop(void) {
  String addresse;
      // try to parse packet
  int packetSize = LoRa.parsePacket();
  if (packetSize) {
    Serial.println("recu");
    // received a packet
    

    // read packet
    while (LoRa.available()) {
      String LoRaData = LoRa.readString();
      Serial.println(LoRaData);
      if(LoRaData == (NUM_MODULE + "getAddr\n")){
        Serial.println("Requete d'addressage...");
        addresse = "";
        for (int i = 0;  i < deviceCount;  i++) 
        { 
          sensors.getAddress(Thermometer, i); 
          
          for(int j=0; j<=7; j++)
          {
            if (Thermometer[j] < 0x10) addresse += String(0);
            addresse += String(Thermometer[j], HEX); 
          }
          addresse += "#";
        }
        LoRa.beginPacket();
        LoRa.print(addresse);
        LoRa.endPacket();
        
      }else if(LoRaData.startsWith(NUM_MODULE + "getTemp-")){
        addresse = "";
        LoRaData.replace(NUM_MODULE + "getTemp-", "");
        LoRaData.trim();
        Serial.println(LoRaData.toInt());
        sensors.requestTemperatures();

        addresse += (String)sensors.getTempCByIndex(LoRaData.toInt());
        addresse += "#";

        sensors.getAddress(Thermometer, LoRaData.toInt());
        for(int i=0; i<=7; i++)
          {
            if (Thermometer[i] < 0x10) addresse += String(0);
            addresse += String(Thermometer[i], HEX); 
          }
        
        LoRa.beginPacket();
        LoRa.print(addresse);
        LoRa.endPacket();
        
      }
    }
  }
} 

  

void printAddress(DeviceAddress deviceAddress) 

{  

  for (uint8_t i = 0; i < 8; i++) 

  { 

    Serial.print("0x"); 

    if (deviceAddress[i] < 0x10) Serial.print("0"); 

    Serial.print(deviceAddress[i], HEX); 

    if (i < 7) Serial.print(", "); 

  } 

  Serial.println(""); 

} 
