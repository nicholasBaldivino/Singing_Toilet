

void setup()
{
  Serial.begin(9600);
  pinMode(2, INPUT);
  
}

void loop() 
{
  int buttonState = digitalRead(2);

  if(buttonState == HIGH)
  {
    Serial.println("On");
  }
  else
  {
    Serial.println("Off");
  }

  delay(1000);

  

  
  

}
