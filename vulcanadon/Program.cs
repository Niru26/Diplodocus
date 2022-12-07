Console.Clear();
//Task 10
Console.WriteLine("Task 10");

int getInteger() {
    return Convert.ToInt32(Console.ReadLine());
}

void show2ndNumber () {
    Console.WriteLine("Enter three-digit number");
    int number = getInteger();
    
    if (number < 100 || number > 999) {
        Console.WriteLine("I ask you one more time - enter three-digit number");
    } else {
        int secondNumber = number % 100 / 10;
        Console.WriteLine(secondNumber);
    }
}

show2ndNumber();
Console.WriteLine("End task 10");
Console.WriteLine("");
// Task 13
C