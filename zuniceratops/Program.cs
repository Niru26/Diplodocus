Console.Clear();
//Task 2
// Console.WriteLine("Task 2");
int requestData() {
    return Convert.ToInt32(Console.ReadLine());
}

// void showMax() {
//     int maximumValue = requestData();
//     int minimumValue = requestData();
    
//     if (minimumValue > maximumValue) {
//         int temporary = maximumValue;
//         maximumValue = minimumValue;
//         minimumValue = temporary;
        
//     }
//     Console.WriteLine($"Maximum value is {maximumValue} and minimum value is {minimumValue}.");
// }

// showMax();
// Console.WriteLine("End of task 2");
// Console.WriteLine("");

//Task 4
// int makeArray(int quntity) {
//     int[] dataToCompare = new int[quntity];
//     int counter = 0;

//     while (counter < quntity) {
//         int arrayValue = requestData();
//         dataToCompare[counter] = arrayValue;
        
//         counter++;
//     }

//     return dataToCompare;
// }

// int generatedArray = makeArray(3);

int[] dataToCompare = new int[3];
int counter = 0;

while(counter < 3) {
        int arrayValue = requestData();
        dataToCompare[counter] = arrayValue;
        counter++;
}

// Console.WriteLine($"This is Long time searched value - ${dataToCompare.Length}");
    
// void printArray(int[] array){
//     int counter = 0;
//     while(counter < array.Length) {
//     Console.WriteLine($"This is {counter} number of array - {array[counter]}");
//     counter++;
//     }
// }

// printArray(generatedArray);

int test(int[] array) {
    int sum = array[0] + array[1];
    return ;
}

int result = test(dataToCompare);
Console.WriteLine(result);





