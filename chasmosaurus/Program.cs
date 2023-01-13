Console.Clear();
Console.WriteLine("Homework 8 by Rudakov N.");
Console.WriteLine("Task 54");
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

int[,] sortArrayRows(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    int temporary = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temporary;
                }
            }
        }
    }
    return array;
}

int[,] initialArray = generate2dIntegerArray();
Console.WriteLine("Initial array:");
show2dIntegerArray(initialArray);
Console.WriteLine("Sorted array:");
int[,] sortedArray = sortArrayRows(initialArray);
show2dIntegerArray(sortedArray);
Console.WriteLine("End task 54");
// Task 56
Console.WriteLine("Task 56");

void showRowSum(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
        }
        Console.WriteLine($"{i + 1} row sum equal to: {sumRow}");
    }
    Console.WriteLine(' ');
}

int[] makeRowSumArray(int[,] array)
{
    int[] rowSummary = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
        }
        rowSummary[i] = sumRow;
    }
    return rowSummary;
}

void showMinimumSumRowNumber(int[] array)
{
    int minimumIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[minimumIndex] > array[i])
        {
            minimumIndex = i;
        }
    }
    Console.WriteLine($"Row number with minimum sum is: {minimumIndex + 1}");
}

int[,] task56initialArray = generate2dIntegerArray();
show2dIntegerArray(task56initialArray);
int[] rowSumArray = makeRowSumArray(task56initialArray);
showRowSum(task56initialArray);
showMinimumSumRowNumber(rowSumArray);
Console.WriteLine("End task 56");
// Task 58
Console.WriteLine(' ');
Console.WriteLine("Task 58");
Console.WriteLine("Create A matrix:");
int[,] matrixA = generate2dIntegerArray();
// int[,] matrixA = { { 2, 4 }, { 3, 2 } };
Console.WriteLine("Create B matrix:");
int[,] matrixB = generate2dIntegerArray();
// int[,] matrixB = { { 3, 4 }, { 3, 3 } };

void show1dArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine(' ');
}

Console.WriteLine("A matrix");
show2dIntegerArray(matrixA);
Console.WriteLine("B matrix");
show2dIntegerArray(matrixB);

void matrixMultiply(int[,] matrixA, int[,] matrixB)
{
    int matrixAcolumns = matrixA.GetLength(1);
    int matrixBrows = matrixB.GetLength(0);
    int matrixArows = matrixA.GetLength(0);
    int matrixBcolumns = matrixB.GetLength(1);
    int[,] matrixC = new int[matrixArows, matrixBcolumns];

    if (matrixAcolumns == matrixBrows)
    {
        for (int i = 0; i < matrixArows; i++)
        {
            for (int k = 0; k < matrixBcolumns; k++)
            {
                // Console.WriteLine($"New J loop");
                for (int j = 0; j < matrixBcolumns; j++)
                {
                    matrixC[i, k] += matrixA[i, j] * matrixB[j, k];
                    // Console.WriteLine($"Cycle J: i -> {i}, j -> {j} k -> {k}");
                }
            }
        }
    }
    else
    {
        Console.WriteLine(' ');
        Console.WriteLine("Wrong matrix data");
        return;
    }
    Console.WriteLine("Matrix multiply result:");
    show2dIntegerArray(matrixC);
}

matrixMultiply(matrixA, matrixB);
Console.WriteLine("End task 58");
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

Console.WriteLine("Source array:");
int[] sourceArray = fillArray();
show1dArray(sourceArray);
Console.WriteLine($"Initial array length: {sourceArray.Length}");
Console.WriteLine(' ');

int[] removeArrayElement(int index, int[] sourceArray)
{
    int reducer = 1;
    int size = sourceArray.Length - reducer;
    int[] editedArray = new int[size];
    int magnifier = 0;
    for (int i = 0; i < size; i++)
    {
        if (i == index)
        {
            magnifier = 1;
        }
        editedArray[i] = sourceArray[i + magnifier];
    }
    reducer++;
    return editedArray;
}

int[,,] generate3dArray()
{
    Console.WriteLine("Enter X axis elements:");
    int xAxis = getData();
    Console.WriteLine("Enter Y axis elements:");
    int yAxis = getData();
    Console.WriteLine("Enter Z axis elements:");
    int zAxis = getData();
    int minimum = 0;
    int maximum = 90;
    int reducer = 0;

    int[,,] resultArray = new int[xAxis, yAxis, zAxis];
    if (xAxis * yAxis * zAxis <= 90)
    {
        for (int i = 0; i < xAxis; i++)
        {
            for (int j = 0; j < yAxis; j++)
            {
                for (int k = 0; k < zAxis; k++)
                {
                    int index = new Random().Next(minimum, maximum - reducer);
                    int value = sourceArray[index];
                    resultArray[i, j, k] = value;
                    sourceArray = removeArrayElement(index, sourceArray);
                    reducer++;
                }
            }
        }
        return resultArray;
    }
    else
    {
        Console.WriteLine("Elements qantity must be less or equal 90");
        return resultArray = new int[0, 0, 0];
    }
}

void show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({j},{k},{i}) ");
            }
            Console.WriteLine(' ');
        }
    }
}
int[,,] finalUniqueArray = generate3dArray();
show3dArray(finalUniqueArray);
Console.WriteLine("End task 60");
// Task 62
Console.WriteLine(' ');
Console.WriteLine("Task 62");

int[,] drawSpiral()
{
    int row = 4;
    int columns = 4;
    int[,] finalResult = new int[row, columns];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            finalResult[i, j] = j + i;
        }
    }
    return finalResult;
}

show2dIntegerArray(drawSpiral());

// int[,,] genrated3dArray = generate3dArray();
// Console.WriteLine(' ');
// show3dArray(genrated3dArray);

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
//     int magnifier = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             rowsInArray[magnifier + j] = array[i, j];
//         }
//         magnifier += array.GetLength(1);
//     }
//     return rowsInArray;
// }

// int[] unwrapingMatixbyColumn(int[,] array)
// {
//     int arraySize = array.GetLength(0) * array.GetLength(1);
//     int[] columnsInArray = new int[arraySize];
//     int magnifier = 0;

//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             columnsInArray[magnifier + j] = array[j, i];
//         }
//         magnifier += array.GetLength(0);
//     }
//     return columnsInArray;
// }

