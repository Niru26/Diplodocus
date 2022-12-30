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
// Console.WriteLine("Task 56");


// void showRowSum(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sumRow = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sumRow += array[i, j];
//         }
//         Console.WriteLine($"{i + 1} row sum equal to: {sumRow}");
//     }
//     Console.WriteLine(' ');
// }

// int[] makeRowSumArray(int[,] array)
// {
//     int[] rowSummary = new int[array.GetLength(0)];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sumRow = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sumRow += array[i, j];
//         }
//         rowSummary[i] = sumRow;
//     }
//     return rowSummary;
// }

// void showMinimumSumRowNumber(int[] array)
// {
//     int minimumIndex = 0;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[minimumIndex] > array[i])
//         {
//             minimumIndex = i;
//         }
//     }
//     Console.WriteLine($"Row number with minimum sum is: {minimumIndex + 1}");
// }

// int[,] task56initialArray = generate2dIntegerArray();
// show2dIntegerArray(task56initialArray);
// int[] rowSumArray = makeRowSumArray(task56initialArray);
// showRowSum(task56initialArray);
// showMinimumSumRowNumber(rowSumArray);
// Console.WriteLine("End task 56");
//Task 58
// Console.WriteLine(' ');
// Console.WriteLine("Task 58");
// Console.WriteLine("Create A matrix:");
// int[,] matrixA = generate2dIntegerArray();
// // int[,] matrixA = { { 2, 4 }, { 3, 2 } };
// Console.WriteLine("Create B matrix:");
// int[,] matrixB = generate2dIntegerArray();
// // int[,] matrixB = { { 3, 4 }, { 3, 3 } };

void show1dArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

// Console.WriteLine("A matrix");
// show2dIntegerArray(matrixA);
// Console.WriteLine("B matrix");
// show2dIntegerArray(matrixB);

// void matrixMultiply(int[,] matrixA, int[,] matrixB)
// {
//     int matrixAcolumns = matrixA.GetLength(1);
//     int matrixBrows = matrixB.GetLength(0);
//     int matrixArows = matrixA.GetLength(0);
//     int matrixBcolumns = matrixB.GetLength(1);
//     int[,] matrixC = new int[matrixArows, matrixBcolumns];

//     if (matrixAcolumns == matrixBrows)
//     {
//         for (int i = 0; i < matrixArows; i++)
//         {
//             for (int k = 0; k < matrixBcolumns; k++)
//             {
//                 // Console.WriteLine($"New J loop");
//                 for (int j = 0; j < matrixBcolumns; j++)
//                 {
//                     matrixC[i, k] += matrixA[i, j] * matrixB[j, k];
//                     // Console.WriteLine($"Cycle J: i -> {i}, j -> {j} k -> {k}");
//                 }
//             }
//         }
//     }
//     else
//     {
//         Console.WriteLine(' ');
//         Console.WriteLine("Wrong matrix data");
//         return;
//     }
//     Console.WriteLine("Matrix multiply result:");
//     show2dIntegerArray(matrixC);
// }

// matrixMultiply(matrixA, matrixB);
// Console.WriteLine("End task 58");
// Task 60
Console.WriteLine("Task 60");

int[] fillArray()
{
    int size = 90;
    int[] result = new int[size];
    int start = 10;
    for (int i = 0; i < size; i++)
    {
        result[i] = start + i;
    }
    return result;
}





// Draft
//  int[] unrapedByRow = unwrapingMatixbyRow(matrixA);
//  int[] unrapedByColumn = unwrapingMatixbyColumn(matrixB);
//  Console.Write("Row value sequence: ");
//  show1dArray(unrapedByRow);
//  Console.WriteLine(' ');
//  Console.Write("Column value sequence: ");
//  show1dArray(unrapedByColumn);
// int[] unwrapingMatixbyRow(int[,] array)
// {
//     int arraySize = array.GetLength(0) * array.GetLength(1);
//     int[] rowsInArray = new int[arraySize];
//     int step = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             rowsInArray[step + j] = array[i, j];
//         }
//         step += array.GetLength(1);
//     }
//     return rowsInArray;
// }

// int[] unwrapingMatixbyColumn(int[,] array)
// {
//     int arraySize = array.GetLength(0) * array.GetLength(1);
//     int[] columnsInArray = new int[arraySize];
//     int step = 0;

//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             columnsInArray[step + j] = array[j, i];
//         }
//         step += array.GetLength(0);
//     }
//     return columnsInArray;
// }

