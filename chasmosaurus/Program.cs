Console.Clear();
Console.WriteLine("Homework 8 by Rudakov N.");
// Console.WriteLine("Task 54");
// // Task 54
int getData()
{
    return Convert.ToInt32(Console.ReadLine());
}

int[,] generate2dIntegerArray()
{
    Console.WriteLine("Enter array min & max:");
    int minimum = getData();
    int maximum = getData();
    Console.WriteLine("Enter array rows & columns:");
    int rows = getData();
    int columns = getData();
    Console.WriteLine(' ');
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minimum, maximum);
        }
    }
    return array;
}

void show2dIntegerArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine(' ');
    }
    Console.WriteLine(' ');
}

// int[,] sortArrayRows(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = j + 1; k < array.GetLength(1); k++)
//             {
//                 if (array[i, j] < array[i, k])
//                 {
//                     int temporary = array[i, j];
//                     array[i, j] = array[i, k];
//                     array[i, k] = temporary;
//                 }
//             }
//         }
//     }
//     return array;
// }

// int[,] initialArray = generate2dIntegerArray();
// Console.WriteLine("Initial array:");
// show2dIntegerArray(initialArray);
// Console.WriteLine("Sorted array:");
// int[,] sortedArray = sortArrayRows(initialArray);
// show2dIntegerArray(sortedArray);
// Console.WriteLine("End task 54");
// Task 56
Console.WriteLine("Task 56");

void sumOfRowValues(int[,] array) {
    int sumValuesResultMin = 0;
    int sumValuesResultCurrent = 0;
    int rowPosition = 0;
    for(int i = 0; i < array.GetLength(0); i++) {
        for(int j = 0; j < array.GetLength(1); j++) {
            sumValuesResultCurrent += array[i,j];
        }
        if(sumValuesResultCurrent < sumValuesResultMin) {
            rowPosition = i;
        }
    }

    Console.WriteLine($"Row with smallest summary is: {rowPosition + 1}");
}

int task56initialArray = generate2dIntegerArray();
show2dIntegerArray(task56initialArray);
sumOfRowValues(task56initialArray);

