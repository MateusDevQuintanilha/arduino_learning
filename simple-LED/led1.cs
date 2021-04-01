void setup() {
  pinMode(3, OUTPUT);
}

void loop() {
  digitalWrite(3, HIGH);
  delay(250); 

  digitalWrite(3, LOW);
  delay(250); 
}

// digitalWrite();
// recebe dois parâmetros: a porta; HIGH ou LOW.
// HIGH = ligado; LOW = desligado

//delay();
// recebe 1 parâmetro: número em milisegundos