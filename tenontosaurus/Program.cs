Console.Clear();
Console.WriteLine("Homework 3 by Rudakov N.");
Console.WriteLine("Task 19");
//Task 19
string getData() {
    Console.Write("Enter single word o digital sequency: ");
    return Console.ReadLine();
}

string[] turnOver(string value) {
    int arrayLength = Convert.ToInt32(value.Length);
    string[] outputArray = new string[arrayLength];

    for(int i = 1; i <= arrayLength; i++) {
        outputArray[i - 1] = Convert.ToString(value[arrayLength - i]); //Why nothing dosen't work without convert to string?
    }

    return outputArray;
}

string makeString (string[] array) {
    string outputString = "";
    for(int i = 0; i < array.Length; i++) {
        outputString = outputString + array[i];
    }
    return outputString;
}

bool checkPalindrome(string value1, string value2) {
    if(value1 == value2) {
        return true;
    } else {
        return false;
    }
}

string userData = getData();
string turnOverUserData = makeString(turnOver(userData));
Console.WriteLine(' ');

void printCheckPalindromeResult () {
    bool result = checkPalindrome(userData, turnOverUserData);
    if(result) {
        Console.WriteLine("It is a palindrome.");
    } else {
        Console.WriteLine("Not a palindrome.");
    }
}

Console.WriteLine($"Original string: {userData}");
Console.WriteLine($"Turn over string: {turnOverUserData}");
printCheckPalindromeResult();
