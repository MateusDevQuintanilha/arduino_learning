void setup() {
  pinMode(13, OUTPUT);
}

void heart() {
  digitalWrite(13, HIGH);
  delay(250); 
  digitalWrite(13, LOW);
  delay(250); 
}

void loop() {
  heart();
}