int counter =0;
void setup() 
{
  // put your setup code here, to run once:
  Serial.begin(115200);
  while (!Serial);
}

void loop() {
  // put your main code here, to run repeatedly:
  counter++;
  Serial.print(counter);
  delay(1000);
}
