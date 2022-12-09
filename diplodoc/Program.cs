Console.Clear();

// int i = 300;
// byte b = (byte) i;

// var sigh = "1234";
// int numberSign = Convert.ToUInt16(sigh);

// try
// {
//     var sighTwo = "1234";
//     byte myByte= Convert.ToByte(sighTwo);
//     Console.WriteLine(myByte);
// }
// catch (System.Exception)
// {
//     Console.WriteLine("This can't be casting or converted");
// }
// try
// {
//     var sighThree= "false";
//     bool myBool= Convert.ToBoolean(sighThree);
//     Console.WriteLine(myBool);
// }
// catch (System.Exception)
// {
//     Console.WriteLine("This can't be casting or converted");
// }

// Console.WriteLine(b);
// Console.WriteLine(numberSign);

// int aPost = 1;
// int bPost = aPost++;

// Console.WriteLine("{0} {1}", aPost, bPost );
// Console.WriteLine(bPost);

// int aPre = 9;
// int bPre = ++aPre;

// Console.WriteLine("{0} {1}", aPre, bPre );
// Console.WriteLine(bPre);

// int a = 1;
// int b = 2;
// Console.WriteLine("Result is " + (float)a / (float)b);

// int getSum(int num) {
//     int sum = 0;

//     for(int i = 1; i <= num; i++) {
//         sum = sum + i;
//     }
//     return sum;
// }

// int sumLimit = Convert.ToInt32(Console.ReadLine());
// int result = getSum(sumLimit);
// Console.WriteLine($"Summary - {result}");
int enterNumber() {
    return Convert.ToInt32(Console.ReadLine());
}

// void countNumbers () {
    
//     string number = enterNumber();
//     Console.WriteLine($"This is a count of numbers {number.Length}");
// }

// countNumbers();

// void findFactorial(double number) {

//     double multiply = 1;

//     for (int i = 1; i <= number; i++) {
//         multiply *= i;
//     }
//     Console.WriteLine($"This is factorial {multiply}");
// }

// findFactorial(enterNumber());

int[] fillArray(int size, int minValue, int maxValue) {
    int[] finalArray = new int[size];

    for (int i = 0; i < size; i++) {
        finalArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return finalArray;
}



void showArray (int[] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]} ");
    }
}

showArray(fillArray(enterNumber(), enterNumber(), enterNumber()));




