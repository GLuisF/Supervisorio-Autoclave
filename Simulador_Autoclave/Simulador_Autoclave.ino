#include <EEPROM.h>
char vez = 0;
byte i;
String Ciclo;
void setup() {
  Serial.begin(9600);
}


void loop()
{
  i = EEPROM.read(0);
  Ciclo = String(1240 + i);
  if (vez != 1) {
    vez = 1;
    Serial.println ("         BAUMER HIVAC PLUS         ");
    Serial.println ("-----------------------------------");
    Serial.println ("CICLO Nr." + Ciclo + "                      ");
    Serial.println ("CIC. CONTROLE  541234              ");
    Serial.println ("-----------------------------------");
    Serial.println ("PROGRAMA Nr.5 -  INSTRUMENTAL");
    Serial.println ("-----------------------------------");
    Serial.println ("OPERACAO 1 - PULSE VAC/VAP 16:31:40");
    Serial.println ("                                   ");
    Serial.println ("16:33:42 -0,00  004,0  035,5  DESL.");
    Serial.println ("16:33:42 -0,00  004,0  035,5  DESL.");
    delay (1000);
    Serial.println ("16:33:42 -0,00  004,0  035,5  DESL.");
    delay (1000);
    Serial.println ("16:33:42 -0,00  004,0  035,5  DESL.");
    delay (1000);
    Serial.println ("16:33:42 -0,00  004,0  035,5  DESL.");
    delay (1000);
    Serial.println ("16:33:42 -0,00  004,0  035,5  DESL.");
    delay (1000);
    Serial.println ("16:33:42 -0,00  004,0  035,5  DESL.");
    delay (1000);
    Serial.println ("16:33:42 -0,00  004,0  035,5  DESL.");
    delay (1000);
    Serial.println ("-----------------------------------");
    Serial.println ("OPERACAO 2 - ESTERILIZACAO 17:23:00");
    Serial.println ("16:33:42 -0,00  004,0  035,5  DESL.");
    delay (400);
    Serial.println ("16:33:42 -0,00  004,0  035,5  DESL.");
    delay (400);
    Serial.println ("16:33:42 -0,00  004,0  035,5  DESL.");
    delay (400);
    Serial.println ("16:33:42 -0,00  004,0  035,5  DESL.");
    delay (400);
    Serial.println ("-----------------------------------");
    Serial.println ("OPERACAO 3 - SECAGEM       17:43:00");
    delay (400);
    Serial.println ("16:33:42 -0,00  004,0  035,5  DESL.");
    Serial.println ("16:33:42 -0,00  004,0  035,5  DESL.");
    delay (400);
    Serial.println ("16:33:42 -0,00  004,0  035,5  DESL.");
    delay (400);
    Serial.println ("16:33:42 -0,00  004,0  035,5  DESL.");
    delay (400);
    Serial.println ("16:33:42 -0,00  004,0  035,5  DESL.");
    delay (400);
    Serial.println ("-----------------------------------");
    Serial.println ("OPERACAO 4 - AERACAO       17:23:00");
    Serial.println ("16:33:42 -0,00  004,0  035,5  DESL.");
    delay (400);
    Serial.println ("                                   ");
    Serial.println ("FIM DE CICLO               19:32:15");
    i++;
    EEPROM.write(0, i + '\0');
  }
}
