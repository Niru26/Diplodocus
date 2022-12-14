Console.Clear();
Console.WriteLine("Homework 4 by Rudakov N.");
Console.WriteLine("Task 25");
//Task 25
int getData() {
    return Convert.ToInt32(Console.ReadLine());
}

int exponentiation(){
    Console.Write("Enter number: ");
    int number = getData();
    Console.Write("Enter power: ");
    int power = getData();
    int result = 1;
        
    for (int i = 0; i < power; i++) {
        result *= number;
    }

    return result;
}

void showResult(int value) {
    Console.WriteLine($"This is a function execution result: {value}");
}

showResult(exponentiation());
Console.WriteLine("End Task 25");
Console.WriteLine("");
//Task 27
Console.WriteLine("Task 27");

int sumNumbers() {
    Console.WriteLine("Enter any integer number in range -2.1B to 2.1B:");
    int number = getData();
    if (number < 0) {
        number = number * (-1);
    }
    int result = 0;
    while(number > 0) {
        int term = number % 10;
        result += term;
        number = number / 10;
    }
    return result;
}

showResult(sumNumbers());
Console.WriteLine("End Task 27");
Console.WriteLine("");
//Task 29
Console.WriteLine("Task 29");

int[] createArray() {
    Console.Write("Enter array size: ");
    int size = getData();
    int[] outputArray = new int[size];
    
    Console.WriteLine("Enter array data");
    for (int i = 0; i < size; i++ ) {
        outputArray[i] = getData();
    }
    return outputArray;
}

void showArray() {
    int[] result = createArray();

    Console.Write("Ready array is: ");
    for (int i = 0; i < result.Length; i++) {
        if(result.Length == 1) {
            Console.Write($"[{result[i]}]");
            break;
        }
        if (i == 0) {
            Console.Write($"[{result[i]}, ");
        }
        if (i > 0 && i < (result.Length - 1)) {
            Console.Write($"{result[i]}, ");
        }
        if (i == result.Length - 1) {
            Console.Write($"{result[i]}]");
        }
    }
}

showArray();
Console.WriteLine(' ');
Console.WriteLine("End Task 29");