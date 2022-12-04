Console.Clear();
//Task 2
// Console.WriteLine("Task 2");
int requestData() {
    return Convert.ToInt32(Console.ReadLine());
}

// void showMaxNumber() {
//     int maximumValue = requestData();
//     int minimumValue = requestData();
    
//     if (minimumValue > maximumValue) {
//         int temporary = maximumValue;
//         maximumValue = minimumValue;
//         minimumValue = temporary;
        
//     }
//     Console.WriteLine($"Maximum value is {maximumValue} and minimum value is {minimumValue}.");
// }

// showMaxNumber();
// Console.WriteLine("End of task 2");
// Console.WriteLine("");

//Task 4
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

    // Console.WriteLine($"We found a maximum - {maxNumber}");
    Console.WriteLine($"We found a maximum - {maxNumber}");
}

showMaxArray(generatedArray);




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





