Console.Clear();

// Задача 1
// Console.Write($"Enter your number one ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Enter your number two ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int quad = number2 * number2;

// if (number1 == quad) {
//     Console.WriteLine("Yes! You are right!");
// } else {
//     Console.WriteLine("Nope, think, Vasya, think...");
// }

// Задача 2
// Console.Write("Enter range number ");
// int range = Convert.ToInt32(Console.ReadLine());

// int counter = -range;

// while(counter <= range) {
//     Console.Write($"{counter} ");
//     counter++;
// }

Console.Clear();
Console.WriteLine("Workshop 4 2D-array & recursion");

// string[,] table = new string[2, 3];
// //assign 
// table[0, 2] = "word";
// //show array using loop in loop

// for(int rows = 0; rows < table.GetLength(0); rows++) {
//     for(int columns = 0; columns < table.GetLength(1); columns++){
//         Console.Write($"*{table[rows, columns]}* ");
//     }
//     Console.WriteLine(' ');
// }

// int[,] table = new int[2, 3];
// //assign 
// table[0, 1] = 5;
// //show array using loop in loop

// for(int rows = 0; rows < table.GetLength(0); rows++) {
//     for(int columns = 0; columns < table.GetLength(1); columns++){
//         Console.Write($"{table[rows, columns]} ");
//     }
//     Console.WriteLine(' ');
// }
// // Factorial
// int factorial (int n) {
//     if (n == 1) {
//         return 1;
//     } else {
//         return n * factorial(n - 1);
//     }
// }

// Console.WriteLine(factorial(5));

int Fibbanci (int n) {
    if(n == 1 || n == 2) {
        return n = 1;
    } else {
        return Fibbanci (n - 1) + Fibbanci (n - 2);
    }
}

for (int i = 1; i <= 20; i++){
    Console.WriteLine($"{i} - {Fibbanci(i)}");
}



