Console.Clear();
Console.WriteLine("Homework 4 by Rudakov N.");
Console.WriteLine("Task 25");
//Task 25
string getData() {
    return Console.ReadLine();
}

// int exponentiation(){
//     Console.Write("Enter number: ");
//     int number = Convert.ToInt32(getData());
//     Console.Write("Enter power: ");
//     int power = Convert.ToInt32(getData());
//     int result = 1;
        
//     for (int i = 0; i < power; i++) {
//         result *= number;
//     }

//     return result;
// }

void showResult(int value) {
    Console.WriteLine($"This is a function execution result: {value}");
}

// showResult(exponentiation());
// Console.WriteLine("End Task 25");
// Console.WriteLine("");
//Task 27
// Console.WriteLine("Task 27");

// int sumNumbers() {
//     Console.WriteLine("Enter any integer number in range -2.1B to 2.1B:");
//     int number = Convert.ToInt32(getData());
//     if (number < 0) {
//         number = number * (-1);
//     }
//     int result = 0;
//     while(number > 0) {
//         int term = number % 10;
//         result += term;
//         number = number / 10;
//     }
//     return result;
// }

// showResult(sumNumbers());
// Console.WriteLine("End Task 27");
// Console.WriteLine("");