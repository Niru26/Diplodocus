Console.Clear();
Console.WriteLine("Homework 7 by Rudakov N.");
//Task 47
Console.WriteLine("Task 47");

int getInt32Data() {
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Enter array numbers range, minimum & maximum:");
int minimum = getInt32Data();
int maximum = getInt32Data();

double genrateDoubleNumber() {
    int numberBase = new Random().Next(minimum, maximum);
    double numberDecimalPart = new Random().NextDouble();
    double number = numberBase + Math.Round(numberDecimalPart, 2);
    return number;    
}

double[,] generate2dArray(){
    Console.WriteLine("Enter array rows quantity:");
    int rowsAmount = getInt32Data();
    Console.WriteLine("Enter array columns quantity:");
    int columnsAmount = getInt32Data();
    double[,] array = new double[rowsAmount, columnsAmount];
    for(int i = 0; i < rowsAmount; i++) {
        for(int j = 0; j < columnsAmount; j++) {    
            array[i, j] = genrateDoubleNumber();
        }
    }
    return array;
}

void show2DDoubleArray(double[,] array) {
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++) {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine(' ');
    }
    Console.WriteLine(' ');
}

double[,] arrayTask47 = generate2dArray();
show2DDoubleArray(arrayTask47);
Console.WriteLine("End task 47");
Console.WriteLine(' ');
//Task 50
Console.WriteLine("Task 50");

Console.WriteLine("Enter row position:");
int rowPosition = getInt32Data();
Console.WriteLine("Enter column position:");
int columnPosition = getInt32Data();

void checkElementInArray(double[,] array) {
    // int rowNumbers = GetLength(0);
    // int columnNumbers = GetLength(1);
    if(array.GetLength(0) < rowPosition || array.GetLength(1) < columnPosition) {
        Console.WriteLine("Element dosn't belong to array");
    } else {
        Console.WriteLine($"Element in {rowPosition}, {columnPosition} equal to {array[rowPosition, columnPosition]}");
    }
}

checkElementInArray(arrayTask47);
Console.WriteLine("End task 50");
Console.WriteLine(' ');
//Task 52
Console.WriteLine("End task 47");

