﻿Console.Clear();

int xa = 40, ya =1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

int x = xa, y = yb;
int count = 0;

while (count < 10000) {
    int randomiser = new Random().Next(0, 3);
    if (randomiser == 0) 
    {
        x = (x + xa) /2;
        y = (y + ya) /2;
    }
    if (randomiser == 1) 
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2; 
    }
     if (randomiser == 2) 
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("X");
    count++;
};
Console.SetCursorPosition(0, 31);

