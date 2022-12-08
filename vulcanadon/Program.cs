Console.Clear();
Console.WriteLine("Homework 2 by Rudakov N.");
// //Task 10
Console.WriteLine("Task 10");

double enterNumber() {
    return Convert.ToDouble(Console.ReadLine());
}

void show2ndNumber () {
    Console.WriteLine("Enter three-digit number");
    double number = enterNumber();
    
    if (number < 100 || number > 999) {
        Console.WriteLine("");
        Console.WriteLine("I ask you one more time - enter three-digit number");
        show2ndNumber();
    } else {
        double secondNumber = Math.Floor(number % 100 / 10);
        Console.WriteLine(secondNumber);
    }
}

show2ndNumber();
Console.WriteLine("End task 10");
Console.WriteLine("");

// Task 13
Console.WriteLine("Task 13");
void show3dNumber() {
    
    Console.WriteLine("Enter at least three-digit number");
    double number = enterNumber();
    
    if (number < 100) {
        Console.WriteLine("No 3d number, sorry.");
        return;
    }
    
    if(number > 999) {
        while(number > 999) {
            number = number/10;
        }
    }

    double result = Math.Floor(number % 10); 
    Console.WriteLine("");
    Console.WriteLine($"Your number is - {result}");
}

show3dNumber();
Console.WriteLine("End task 13");
Console.WriteLine("");

// Task 15
Console.WriteLine("Task 15");
void showHolidayNumber() {
    Console.WriteLine("Please, enter integer number between 1 and 7");
    double number = Math.Floor(enterNumber());
    
    if(number < 1 || number > 7) {
        Console.WriteLine("");
        Console.WriteLine("Enter correct number");
        showHolidayNumber();
    } else {
        if (number >= 1 && number < 6) {
            Console.WriteLine("It is a working day");
        } else {
            Console.WriteLine("Uray, it is a holiday!");
        }
    }
}

showHolidayNumber();
Console.WriteLine("");
Console.WriteLine("End task 15");




