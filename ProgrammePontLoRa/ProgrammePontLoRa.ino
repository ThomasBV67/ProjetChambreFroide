#include <SPI.h>
#include <LoRa.h>
#include <avr/wdt.h>

//define the pins used by the transceiver module
#define ss 10
#define rst 9
#define dio0 2

int counter = 0;

void setup() {
  //initialize Serial Monitor
  Serial.begin(115200);
  while (!Serial);
  
  //setup LoRa transceiver module
  LoRa.setPins(ss, rst, dio0);
  
  //replace the LoRa.begin(---E-) argument with your location's frequency 
  //433E6 for Asia
  //866E6 for Europe
  //915E6 for North America
  while (!LoRa.begin(915E6)) {
    delay(500);
  }
   // Change sync word (0xF3) to match the receiver
  // The sync word assures you don't get LoRa messages from other LoRa transceivers
  // ranges from 0-0xFF
  LoRa.setSyncWord(0x45);
  wdt_enable(WDTO_8S);
}
void loop(){
  int packetSize = LoRa.parsePacket();
  if (packetSize) {
    while (LoRa.available()) {
      Serial.println(LoRa.readString());
    }
  }
  if(Serial.available()){
    LoRa.beginPacket();
    LoRa.print(Serial.readString());
    LoRa.endPacket();
  }
  wdt_reset();
}
