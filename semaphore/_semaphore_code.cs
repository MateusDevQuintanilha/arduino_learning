int pins[] = {13, 12, 11};

void setup() {
  for (int i = 0; i <= pins[0]; i++) {
  	pinMode(pins[i], OUTPUT);
  }
}

void red_on() {
  digitalWrite(13, HIGH);
  digitalWrite(12, LOW);
  digitalWrite(11, LOW);
  delay(4000);
}

void green_on() {
  digitalWrite(13, LOW);
  digitalWrite(12, LOW);
  digitalWrite(11, HIGH);
  delay(4000);
}

void yellow_on() {
  digitalWrite(13, LOW);
  digitalWrite(12, HIGH);
  digitalWrite(11, LOW);
  delay(4000);
}

void loop() {
 red_on();
 green_on();
 yellow_on();
}