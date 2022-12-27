Console.Clear();
Console.WriteLine("Homework 8 by Rudakov N.");
Console.WriteLine("Task 54");
// Task 54
int getData() {
    return Convert.ToInt32(Console.ReadLine());
}

int [,] generate2dIntegerArray() {
    Console.WriteLine("Enter array min & max:");
    int minimum = getData();
    int maximum = getData();
    Console.WriteLine("Enter array rows & columns:");
    int rows = getData();
    int columns = getData();
    Console.WriteLine(' ');
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < columns; j++) {
            array[i,j] = new Random().Next(minimum, maximum);
        }
    }
    return array;
}

void show2dIntegerArray(int[,] array) {
    for(int i = 0; i < array.GetLength(0); i++) {
        for(int j = 0; j < array.GetLength(1); j++ ) {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine(' ');
    }
    Console.WriteLine(' ');
}

show2dIntegerArray(generate2dIntegerArray());