#include <Key.h>
#include <Keypad.h>
#define SEGMENET_A 7
#define SEGMENET_B 8
#define SEGMENET_C 9
#define SEGMENET_D 10
#define SEGMENET_E 11
#define SEGMENET_F 12
#define SEGMENET_G 13
int segments[7]={SEGMENET_A, SEGMENET_B, SEGMENET_C, SEGMENET_D, SEGMENET_E, SEGMENET_F, SEGMENET_G};
byte signals[10] [7]={
    {0,0,0,0,0,0,1}, //0
    {1,0,0,1,1,1,1}, //1
    {0,0,1,0,0,1,0}, //2
    {0,0,0,0,1,1,0}, //3
    {1,0,0,1,1,0,0}, //4
    {0,1,0,0,1,0,0}, //5
    {0,1,0,0,0,0,0}, //6
    {0,0,0,1,1,1,1}, //7
    {0,0,0,0,0,0,0}, //8
    {0,0,0,0,1,0,0} //9
};
byte ROWS=4;
byte COLS=3;

char keys [ROWS][COLS]={
    {'1','2','3'},
    {'4','5','6'},
    {'7','8','9'},
    {'*','0','#'}
};

byte rowPines[ROWS]={6,5,4,3};
byte colPines[COLS]={2,1,0};

Keypad klava=Keypad(makeKeymap(keys), rowPines, colPines, ROWS, COLS);
int digit=0;
void setup() {
    for (int i=0; i<=7; i++) {
        pinMode(segments[i], OUTPUT);
    }
    Serial.begin(9600);
}
void loop() {
    char customKey=klava.getKey();
    if (customKey) {
        if (customKey=='*' || customKey=='#') {
            digit=0;
        }
        else {
            digit=int(customKey)-48;
        }
        for (int segment=0; segment<7; segment++) {
            Serial.println(signals[digit][segment]);
            digitalWrite(segments[segment], signals[digit][segment]);
        }
    }
}
/*if (digitalRead(5)==1){
        Serial.println("Program started...");
        for (int digit=9; digit>=0; digit--) {
            Serial.println(digit);
            for (int segment=0; segment<7; segment++) {
                Serial.println(signals[digit] [segment]);
                digitalWrite(segments[segment], signals[digit] [segment]);
            }
            Serial.println("_____");
            delay(1000);
        }
    }