Console.Clear();

byte smallNumber = 3;
int integerNumber = 234;
float myHight = 181.5F;
double number = 255.21;
char symbol = 'A';
string myName = "Nikolai";
bool switchedOn = false;
bool switchedOff = true;
const float Pi = 3.14f;

Console.WriteLine($"It is number {smallNumber}");
Console.WriteLine(integerNumber);
Console.WriteLine($"Not excatly {myHight}");
Console.WriteLine($"Double double {number}");
Console.WriteLine(symbol);
Console.WriteLine(myName);
Console.WriteLine(switchedOn);
Console.WriteLine($"{switchedOff} {myName} {symbol}");
Console.WriteLine("{0} {1} {2}", int.MaxValue, byte.MaxValue, double.MaxValue);
Console.WriteLine(Pi);