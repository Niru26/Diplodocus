Console.Clear();
Console.WriteLine("Homework 3 by Rudakov N.");
// Console.WriteLine("Task 19");
// // Task 19
// string getData() {
//     Console.Write("Enter single word o digital sequency: ");
//     return Console.ReadLine();
// }

// string[] turnOver(string value) {
//     int arrayLength = Convert.ToInt32(value.Length);
//     string[] outputArray = new string[arrayLength];

//     for(int i = 1; i <= arrayLength; i++) {
//         outputArray[i - 1] = Convert.ToString(value[arrayLength - i]); //Why nothing dosen't work without convert to string?
//     }

//     return outputArray;
// }

// string makeString (string[] array) {
//     string outputString = "";
//     for(int i = 0; i < array.Length; i++) {
//         outputString = outputString + array[i];
//     }
//     return outputString;
// }

// bool checkPalindrome(string value1, string value2) {
//     if(value1 == value2) {
//         return true;
//     } else {
//         return false;
//     }
// }

// string userData = getData();
// string turnOverUserData = makeString(turnOver(userData));
// Console.WriteLine(' ');

// void printCheckPalindromeResult () {
//     bool result = checkPalindrome(userData, turnOverUserData);
//     if(result) {
//         Console.WriteLine("It is a palindrome.");
//     } else {
//         Console.WriteLine("Not a palindrome.");
//     }
// }

// Console.WriteLine($"Original string: {userData}");
// Console.WriteLine($"Turn over string: {turnOverUserData}");
// printCheckPalindromeResult();
// Console.WriteLine("End task 19");
// Console.WriteLine("");
// //Task 21
Console.WriteLine("Task 21");

double[] record3dDot () {
    int arraySize = 3;
    double[] dot = new double[arraySize];
    for(int i = 0; i < arraySize; i++) {
        double coordinat = Convert.ToDouble(Console.ReadLine());
        dot[i] = coordinat;
    }
    return dot;
}

void showArray(double[] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]}, ");
    }
}

void calculateDistance() {
    Console.WriteLine("Enter 1st dot coordinates:");
    double[] dot1 = record3dDot();
    Console.WriteLine("Enter 2nd dot coordinates:");
    double[] dot2 = record3dDot();

    double result = Math.Sqrt((Math.Pow((dot1[0] - dot2[0]),2) + Math.Pow((dot1[1] - dot2[1]),2)) + Math.Pow((dot1[2] - dot2[2]),2));

    Console.Write($"1st dot coordinates: ");
    showArray(dot1);
    Console.WriteLine("");
    Console.Write($"2nd dot coordinates: ");
    showArray(dot2);
    Console.WriteLine("");
    Console.WriteLine($"Distanse between this dots equals to: {Math.Round((result),2)}");
}

calculateDistance();
Console.WriteLine("End task 21");
Console.WriteLine("");