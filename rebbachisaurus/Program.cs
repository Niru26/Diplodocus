Console.Clear();
Console.WriteLine("Homework 5 by Rudakov N.");
// Console.WriteLine("Task 34");
// //Task 34
int getIntData () {
    return Convert.ToInt32(Console.ReadLine());
}


int [] generateRandomArray() {
    Console.Write("Enter array size: ");
    int size = getIntData();
    Console.Write("Enter array minimal value: ");
    int minValue = getIntData();
    Console.Write("Enter array maximum value: ");
    int maxValue = getIntData(); 
    int [] outputArray = new int [size];
    for(int i = 0; i < size; i++) {
        outputArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return outputArray;
}

void showArray(int [] array) {
        Console.WriteLine("Array elements: ");
        for(int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]} ");
    }
}

// int countEven(int[] array) {
//     int counter = 0;
//     for (int i = 0; i < array.Length; i++) {
//         if (array[i] % 2 == 0) counter++;
//     }
//     return counter;
// }

// void showTaskAnser() {
//     int[] randomArray = generateRandomArray();
//     showArray(randomArray);
//     int result = countEven(randomArray);
//     Console.WriteLine("");
//     Console.WriteLine($"The answer is: {result}");
// }

// showTaskAnser();
// Console.WriteLine("End task 34");
// Console.WriteLine("");
//  Console.WriteLine("Task 36");

//  int sumOddValues(int[] array) {
//     int sum = 0;
//     Console.WriteLine("Value on even index positions:");
//     for (int i = 1; i < array.Length; i += 2) {
//             Console.Write($"{array[i]} ");
//             sum += array[i];
        
//     }
//         return sum;
//  }

// void showTaskAnser() {
//     int[] randomArray = generateRandomArray();
//     showArray(randomArray);
//     Console.WriteLine("");
//     int result = sumOddValues(randomArray);
//     Console.WriteLine("");
//     Console.WriteLine($"The answer is: {result}");
// }

// showTaskAnser();
// Console.WriteLine("End task 36");
// Console.WriteLine("");
//Task 38
Console.WriteLine("Task 38");
//How to write universal show method, here I have to modify "show array" method from int to double?
void showDoubleArray(double[] array) {
        Console.WriteLine("Array elements: ");
        for(int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]} ");
    }
}

double[] generateDoubleArray() {
    int arraySize = getIntData();
    double[] array = new double[arraySize];

    for (int i = 0; i < arraySize; i++) {
        double randaomValue = new Random().Next(10, 100);
        double decimalPart = new Random().NextDouble();
        double roundedDecimalPart = Math.Round(decimalPart, 2);
        array[i] = randaomValue + roundedDecimalPart;
    }

    return array;
}

double[] sortArray(double[] array) {
    int minimumIndex = 0;
   
    for (int i = 1; i < array.Length; i++) {
        if(array[i] < array[minimumIndex]) {
            double temporary = array[i];
            array[i] = array[minimumIndex];
            array[minimumIndex] = temporary;
            minimumIndex = i;
        }
    }
    return array;
}

double[] result = generateDoubleArray();
showDoubleArray(result);
Console.WriteLine(' ');
double[] sorted = sortArray(result);
showDoubleArray(sorted);


// double alternate = new Random().Next(10, 100) + roundedValue;
// Console.WriteLine(alternate);

