/*********
  Programme de test de module LoRa--Envoyeur
  En premier lieu, le programme teste si le module LoRa est accesible et fonctionnel. Si il l'est, il commence l'envoi de messages numérotés.

  Arduino nano avec dragino LoRa + GPS kit

  3 jumpers à l'opposé du module LoRa en pos 1-2

  Brancher le nano comme si c'étais un uno sur un shield SANS OUBLIER LE 3.3V
  
  
*********/

#include <SPI.h>
#include <LoRa.h>

//define the pins used by the transceiver module
#define ss 10
#define rst 9
#define dio0 2

int counter = 0;

void setup() {
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
}

void loop() {
  Serial.print("Sending packet: ");
  Serial.println(counter);

  //Send LoRa packet to receiver
  LoRa.beginPacket();
  LoRa.print("good bye ");
  LoRa.print(counter);
  LoRa.endPacket();

  counter++;

  delay(1000);
}
