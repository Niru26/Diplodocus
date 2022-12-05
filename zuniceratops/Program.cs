Console.Clear();
Console.WriteLine("Homework 1 by Rudakov N.");
//Task 2
Console.WriteLine("Task 2");
int requestData() {
    return Convert.ToInt32(Console.ReadLine());
}

void showMaxNumber() {
    int maximumValue = requestData();
    int minimumValue = requestData();
    
    if (minimumValue > maximumValue) {
        int temporary = maximumValue;
        maximumValue = minimumValue;
        minimumValue = temporary;
        
    }
    Console.WriteLine($"Maximum value is {maximumValue} and minimum value is {minimumValue}.");
}

Console.WriteLine("Enter two integer number, please");
showMaxNumber();
Console.WriteLine("End of task 2");
Console.WriteLine("");

// Task 4
Console.WriteLine("Task 4");

int[] makeArray(int quntity) {
    int[] dataToCompare = new int[quntity];
    int counter = 0;

    while (counter < quntity) {
        int arrayValue = requestData();
        dataToCompare[counter] = arrayValue;
        
        counter++;
    }

    return dataToCompare;
}

Console.WriteLine("Enter array size and values.");
int[] generatedArray = makeArray(requestData());

Console.WriteLine("");
void printArray(int[] array){
    int counter = 0;
    while(counter < array.Length) {
    Console.WriteLine($"This is {counter} index of array - {array[counter]}");
    counter++;
    }
}

printArray(generatedArray);

void showMaxArray(int[] array){
    int maxNumber = array[0];
    int limit = array.Length;

    for(int counter = 0; counter < limit; ++counter) {
        if (maxNumber < array[counter]) {
            maxNumber = array[counter];
        }
    }

    Console.WriteLine($"We found a maximum - {maxNumber}");
}

showMaxArray(generatedArray);
Console.WriteLine("");
Console.WriteLine("End of task 4");
Console.WriteLine("");

//Task 6
Console.WriteLine("Task 6");

bool checkEven(int integer){
    if (integer % 2 == 0) {
        return true;
    }
    return false;
}

string printEven(){
    int integer = requestData();
    if (checkEven(integer)) {
       return "Even";
        
    }
    return "Odd";
}

Console.WriteLine("Enter integer number, please");
Console.WriteLine(printEven());

Console.WriteLine("");
Console.WriteLine("End of Task 6");
Console.WriteLine("");

//Task 8
Console.WriteLine("Task 8");

void showAllEven() {
    Console.WriteLine("Please, enter integer number greater than 1");
    int integer = requestData();
    if (integer <= 1) {
        Console.WriteLine("Next time, do as you been asked!");
    }
    for (int i = 2; i <= integer; i+=2) {
        Console.Write($"{i} ");
    }
}

showAllEven();

Console.WriteLine("");
Console.WriteLine("End of Task 8");









//Draft area

// int[] dataToCompare = new int[3];
// int counter = 0;
// while(counter < 3) {
//         int arrayValue = requestData();
//         dataToCompare[counter] = arrayValue;
//         counter++;
// }
// Console.WriteLine($"This is Long time searched value - ${dataToCompare.Length}");
// int[] test(int[] array) {
//     return array;
// }
// Console.WriteLine(test(dataToCompare)[1]);





