Console.Clear();
Console.WriteLine("Homework 7 by Rudakov N.");
//Task 47
Console.WriteLine("Task 47");

int getInt32Data() {
    return Convert.ToInt32(Console.ReadLine());
}

double genrateDoubleNumber() {
    int minimum = getInt32Data();
    int maximum = getInt32Data();
    int numberBase = new Random().Next(minimum, maximum);
    double numberDecimalPart = new Random().NextDouble();
    double number = numberBase + Math.Round(numberDecimalPart, 2);
    return number;    
}



Console.WriteLine(genrateDoubleNumber());