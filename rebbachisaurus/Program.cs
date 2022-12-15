Console.Clear();
Console.WriteLine("Homework 5 by Rudakov N.");
Console.WriteLine("Task 34");

double[] generateRandomArray(int size, int minValue, int maxValue) {
    double[] outputArray = new double[size];
    for(int i = 0; i < size; i++) {
        outputArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return outputArray;
}

void showDoubleArray(double[] array) {
    
    for(int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]}");
    }
}

showDoubleArray(generateRandomArray(3, -10, 10));