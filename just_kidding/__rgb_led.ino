#define R 2
#define G 4
#define B 3

void setup(){
  	pinMode(R, OUTPUT);
  	pinMode(G, OUTPUT);
  	pinMode(B, OUTPUT); 
}

void loop(){
  	analogWrite(R, random(255));
  	analogWrite(G, random(255));
  	analogWrite(B, random(255));
  	delay(200);
}