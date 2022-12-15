Console.Clear();
Console.WriteLine("Homework 5 by Rudakov N.");
Console.WriteLine("Task 34");
//Task 34
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

void showeArray(int [] array) {
        Console.WriteLine("Array elements: ");
        for(int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]} ");
    }
}

int countEven(int[] array) {
    int counter = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] % 2 == 0) counter++;
    }
    return counter;
}

void showTaskAnser() {
    int[] randomArray = generateRandomArray();
    showeArray(randomArray);
    int result = countEven(randomArray);
    Console.WriteLine("");
    Console.WriteLine($"The answer is: {result}");
}

showTaskAnser();