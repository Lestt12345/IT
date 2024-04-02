#include <Key.h>
int chose=1;
void setup() {
    for (int i=8; i<=13; i++) {
        pinMode(i, OUTPUT);
    }
    Serial.begin(9600);
    pinMode(2, INPUT);
}

void loop() {
    if (digitalRead(2)==1)
    {
        chose++;
        if (chose>3)
        {
            chose=1;
        }
    }
    if (chose==1)
    {
        digitalWrite(8, HIGH);
        digitalWrite(9, LOW);
        digitalWrite(10, LOW);
        digitalWrite(11, HIGH);
        digitalWrite(12, LOW);
        digitalWrite(13, HIGH);
        delay(1000);
        digitalWrite(8, LOW);
        digitalWrite(9, HIGH);
        digitalWrite(10, HIGH);
        digitalWrite(11, LOW);
        digitalWrite(12, LOW);
        digitalWrite(13, HIGH);
        delay(1000);
        digitalWrite(8, HIGH);
        digitalWrite(9, HIGH);
        digitalWrite(10, LOW);
        digitalWrite(11, HIGH);
        digitalWrite(12, LOW);
        digitalWrite(13, LOW);
        delay(1000);
    }
    else if (chose==2)
    {
        digitalWrite(8, LOW);
        digitalWrite(9, LOW);
        digitalWrite(10, LOW);
        digitalWrite(11, LOW);
        digitalWrite(12, LOW);
        digitalWrite(13, LOW);
        for (int i=13; i>=8; i--) {
            digitalWrite(i, HIGH);
            delay(500);
        }
        for (int i=13; i>=8; i--) {
            digitalWrite(i, LOW);
        }
    }
    else if (chose==3)
    {
        for (int i=13; i>=8; i--) {
            digitalWrite(i, HIGH);
        }
        delay(2000);
        for (int i=13; i>=8; i--) {
            digitalWrite(i, LOW);
        }
        delay(2000);
    }
}