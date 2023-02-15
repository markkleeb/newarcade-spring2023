#include <Bounce.h>

Bounce button0 = Bounce(0, 10); //10 = 10ms debounce time
Bounce button1 = Bounce(1, 10);

const int xAxis = A8;
const int yAxis = A9;

void setup() {
  
Serial.begin(9600);
pinMode(0, INPUT_PULLUP);
pinMode(1, INPUT_PULLUP);
}

void loop() {

button0.update();
button1.update();

if(button0.fallingEdge()){
  Keyboard.print(" ");
}
if(button1.fallingEdge()){
  Keyboard.print("z");
}
Serial.print("xAxis: ");
Serial.print(analogRead(xAxis));
Serial.print("   yAxis:  ");
Serial.println(analogRead(yAxis));

Joystick.X(analogRead(xAxis));
Joystick.Y(analogRead(yAxis));
      
delay(10);
}
