int pins[] = {13, 12, 11, 10, 9, 8, 7, 6, 5};

void setup() {
  for(int i = 0; i <= 0; i++) {
	pinMode(pins[i], OUTPUT);
  }
}

void loop()
{
  digitalWrite(13, HIGH);
  delay(20); 
  digitalWrite(13, LOW);
  delay(20);
  
  digitalWrite(12, HIGH);
  delay(20);
  digitalWrite(12, LOW);
  delay(20); 
  
  digitalWrite(11, HIGH);
  delay(20); 
  digitalWrite(11, LOW);
  delay(20); 
  
  digitalWrite(10, HIGH);
  delay(20); 
  digitalWrite(10, LOW);
  delay(20); 
  
  digitalWrite(9, HIGH);
  delay(20); 
  digitalWrite(9, LOW);

  delay(20); 
  digitalWrite(8, HIGH);
  delay(20); 
  digitalWrite(8, LOW);
  delay(20); 
  
  digitalWrite(7, HIGH);
  delay(20); 
  digitalWrite(7, LOW);
  delay(20); 
  
  digitalWrite(6, HIGH);
  delay(20); 
  digitalWrite(6, LOW);
  delay(20); 

  digitalWrite(5, HIGH);
  delay(20); 
  digitalWrite(5, LOW);
  delay(20); 
  
}