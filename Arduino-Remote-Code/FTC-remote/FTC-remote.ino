// https://github.com/VirginiaFIRST/FTC-Match-Timer/
// Schematics:
// https://drive.google.com/open?id=0B1AYv-vKUP25Z2Q4NWY2N3NXRms

int pinA = A1;
int pinB = A2;
int pinC = A3;
int pinD = A4;
int pinV = A0;

int modPwr = A5;

int pinEnabled = 2;
int pinLedS = 3;
int pinLedB = 4;

bool lastA = false;
bool lastB = false;
bool lastC = false;
bool lastD = false;

int appStatus = 0;

bool ledBlink = false;
int ledTime = 0;

void setup()
{
  pinMode(pinA, INPUT);
  pinMode(pinB, INPUT);
  pinMode(pinC, INPUT);
  pinMode(pinD, INPUT);
  pinMode(pinV, INPUT);
  pinMode(modPwr, OUTPUT);

  pinMode(pinEnabled, INPUT_PULLUP);
  pinMode(pinLedS, OUTPUT);
  pinMode(pinLedB, OUTPUT);

  Serial.setTimeout(1000);
  Serial.begin(9600);
}

void loop()
{
  // If the serial port is connected to something
  if(Serial)
  {
    // Read Serial Commands
    readSerial();
    // Get whether we're enabled or not
    bool physicalEnable = !digitalRead(pinEnabled);
    bool vEnabled = physicalEnable && (appStatus != 0);
    // Blink the LED
    ledBlink = !ledBlink;
    digitalWrite(pinLedS, vEnabled && ledBlink);
    // Send power to the RF Module if we're enabled.
    digitalWrite(modPwr, vEnabled);
    // Get pin status
    bool vA = digitalRead(pinA);
    bool vB = digitalRead(pinB);
    bool vC = digitalRead(pinC);
    bool vD = digitalRead(pinD);
    bool vV = digitalRead(pinV);
    // Light the Button Status LED if the V pin is true
    digitalWrite(pinLedB, vV);
    // Build our serial output string
    String s = String(appStatus);
    if(appStatus == 0) s += "00";
    if(appStatus == 1) s += String(vA) + String(vB);
    if(appStatus == 2) s += String(vC) + String(vD);
    s += String(vV);
    // Send pin status to applicaton
    if (physicalEnable) Serial.println(s);
    delay(100);
  }
  else 
  {
    // Remove the application's enablement so the app has to tell us we're good to go again
    appStatus = 0;
    waitForSerial();
  }
}

void waitForSerial()
{
  if(ledTime == 7) ledTime = 0;
    ledTime++;
    bool b = false;
    switch(ledTime)
    {
      case 1: b = true; break;
      case 3: b = true; break;
    }
    digitalWrite(pinLedS, b);
    delay(300);
}

void readSerial()
{
  while (Serial.available())
  {
    char inChar = (char)Serial.read();
    switch(inChar)
    {
      case '1':
        appStatus = 1;
        break;
        case '2':
        appStatus = 2;
        break;
      case '0':
        appStatus = 0;
        break;
      case '9':
        if(appStatus != 0)
        {
          digitalWrite(modPwr, false);
          delay(200);
          digitalWrite(modPwr, true);
        }
        break;
    }
  }
}

