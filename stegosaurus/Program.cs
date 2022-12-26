Console.Clear();
Console.WriteLine("Workshop 7 2D-array");
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

// Console.Clear();
// Console.WriteLine("Workshop 4 2D-array & recursion");

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
// Recursion - Fibbanaci number
// int Fibbanci (int n) {
//     if(n == 1 || n == 2) {
//         return n = 1;
//     } else {
//         return Fibbanci (n - 1) + Fibbanci (n - 2);
//     }
// }

// for (int i = 1; i <= 20; i++){
//     Console.WriteLine($"{i} - {Fibbanci(i)}");
// }
// string myString = "0";
// int i = 5;
// myString = myString + i;
// Console.WriteLine(myString);
// int getIntData() {
//     return Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine("Enter number of rows:");
// int rows = getIntData();
// Console.WriteLine("Enter number of columns:");
// int columns = getIntData();
// Console.WriteLine("Enter minimum value:");
// int minimum = getIntData();
// Console.WriteLine("Enter maximum value:");
// int maximum = getIntData();

// int[,] generate2dRandomArray() {
//     int[,] array = new int[rows, columns];

//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j < columns; j++) {
//             array[i, j] = new Random().Next(minimum, maximum);
//         }
//     }
//     return array;
// }

// void show2dArray(int[,] array) {
//     for(int i = 0; i < array.GetLength(0); i++) {
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine(' ');
//         Console.WriteLine(' ');
//     }
// }

// show2dArray(generate2dRandomArray());

string caption = "C# sucks!!!";
int sreenWidthPosition = (Console.WindowWidth - caption.Length) / 2;
int sreenHightPosition = (Console.WindowHeight)/2;

void drawCaption (string text, int left, int top) {
    Console.SetCursorPosition(left, top);
    Console.WriteLine(caption);
}
 
drawCaption(
    text: caption, 
    left: sreenWidthPosition, 
    top: sreenHightPosition
    );

