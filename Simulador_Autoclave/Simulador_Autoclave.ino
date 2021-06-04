#include <EEPROM.h>
char vez = 0;
byte i;
int intCiclo;
char strCiclo[41];

void EEPROMWriteInt(int address, int value); //2 Bytes
int  EEPROMReadInt(int address);

void setup() {
  Serial.begin(9600);
  randomSeed(analogRead(0));
}

void loop()
{
  intCiclo = EEPROMReadInt(0);
  sprintf(strCiclo, "%04u",intCiclo);
  Serial.print (" \n");
  Serial.print ("---------------------------------------\n");
  Serial.print ("  =    BAUMER    =    -----\n");
  Serial.print (" \n");
  Serial.print (" ÛÛ  REALIZAR MANUTENCAO PREVENTIVA ÛÛ\n");
  Serial.print ("\n");
  Serial.print ("DATA: 07/04/20    HORA: 15:26:48       \n");
  sprintf(strCiclo, "CICLO Nr:     %04u                     \n",intCiclo);
  Serial.print (strCiclo);
  Serial.print ("COD. CARGA: 000483                     \n");
  Serial.print ("---------------------------------------\n");
  Serial.print ("PROGRAMA  Nr: 0"+String(random(1,6))+"  - INSTRUMENTAIS        \n");
  Serial.print ("TEMPERATURA                 134.0 øC   \n");
  Serial.print ("TEMPO ESTERILIZACAO         0004 min   \n");
  Serial.print ("PULSOS DE VACUO               04       \n");
  Serial.print ("TEMPO SECAGEM               0030 min   \n");
  Serial.print ("---------------------------------------\n");
  Serial.print ("  HORA       PCI     TCI     TPR   TTS \n");
  Serial.print ("             Kg      øC      øC    øC  \n");
  Serial.print (" \n");
  Serial.print ("---------------------------------------\n");
  Serial.print ("OPERACAO: 1 - PULSOS VAC/VAP  15:27:01 \n");
  Serial.print (" \n");
  Serial.print (" \n");
  Serial.print ("15:29:03   -0,46    079,0   082,0 DESL.\n"); delay (500);
  Serial.print ("15:31:03   -0,63    083,4   083,6 DESL.\n"); delay (500);
  Serial.print ("  VACUO                                \n");
  Serial.print ("15:33:04   -0,50    082,4   081,4 DESL.\n"); delay (500);
  Serial.print ("---------------------------------------\n");
  Serial.print ("OPERACAO: 2 - ESTERILIZACAO   16:23:22 \n");
  Serial.print (" \n");
  Serial.print (" \n");
  Serial.print ("16:23:22   -0,46    079,0   082,0 DESL.\n"); delay (500);
  Serial.print ("16:25:22   -0,63    083,4   083,6 DESL.\n"); delay (500);
  Serial.print ("  VACUO                                \n");
  Serial.print ("16:27:23   -0,50    082,4   081,4 DESL.\n"); delay (500);
  Serial.print ("16:29:24    0,80    115,7   117,3 DESL.\n"); delay (500);
  Serial.print ("16:41:28   -0,62    093,5   093,4 DESL.\n"); delay (500);
  Serial.print ("16:43:28   -0,65    092,8   092,3 DESL.\n"); delay (500);
  Serial.print ("---------------------------------------\n");
  Serial.print ("OPERACAO: 3 - SECAGEM          17:17:41\n");
  Serial.print (" \n");
  Serial.print (" \n");
  Serial.print ("17:17:41   -0,46    079,0   082,0 DESL.\n"); delay (500);
  Serial.print ("17:19:41   -0,63    083,4   083,6 DESL.\n"); delay (500);
  Serial.print ("  VACUO                                \n");
  Serial.print ("17:21:42   -0,50    082,4   081,4 DESL.\n"); delay (500);
  Serial.print ("  VAPOR                                \n");
  Serial.print ("17:23:43    0,80    115,7   117,3 DESL.\n"); delay (500);
  Serial.print ("17:25:43   -0,04    104,0   103,0 DESL.\n"); delay (500);
  Serial.print ("17:29:45   -0,43    098,3   099,1 DESL.\n"); delay (500);
  Serial.print ("---------------------------------------\n");
  Serial.print ("OPERACAO: 4 - AERACAO          18:12:00\n");
  Serial.print (" \n");
  Serial.print ("18:12:00   -0,46    079,0   082,0 DESL.\n"); delay (500);
  Serial.print ("---------------------------------------\n");
  Serial.print (" \n");
  Serial.print ("FIM DE CICLO                  18:14:02\n");
  Serial.print (" \n");
  Serial.print ("---------------------------------------\n");
  Serial.print ("DURACAO TOTAL:    02:42:57\n");
  Serial.print (" \n");
  Serial.print (" \n");
  Serial.print ("OPER._____________________DAVID GILMOUR\n");
  intCiclo++;
  EEPROMWriteInt(0, intCiclo);
  delay(10000);
}

void EEPROMWriteInt(int address, int value) {
  byte hiByte = highByte(value);
  byte loByte = lowByte(value);
  EEPROM.write(address, hiByte);
  EEPROM.write(address + 1, loByte);
}

int EEPROMReadInt(int address) {
  byte hiByte = EEPROM.read(address);
  byte loByte = EEPROM.read(address + 1);
  return word(hiByte, loByte);
}
