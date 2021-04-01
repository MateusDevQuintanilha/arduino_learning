void setup() {  
	pinMode(3, OUTPUT);
  	pinMode(4, OUTPUT);
}

void loop() {  
  for(int i = 3; i <= 4; i++) {
	digitalWrite(i, HIGH);
	delay(250);

	digitalWrite(i, LOW);
	delay(250);
  }
}