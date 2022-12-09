Console.Clear();

// string myNumber = Console.ReadLine();
// int stringLength = Convert.ToInt32(myNumber.Length);

// Console.WriteLine($"{stringLength} {myNumber[1]}");

// int myRandom = new Random().Next(1, 20);
// Console.WriteLine(DateTime.Today);

int[] unsortedArray = {3, 2, 4, 1, 5, 7, 6, 2, 0, 5, 5};

void printArray(int[] array) {
    int length = array.Length;

    for(int i = 0; i < length; i++) {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void sortArray(int[] array) {
    for (int i =  0; i < array.Length - 1; i++) {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++ ) {
            if (array[j] < array[minPosition]) {
                minPosition = j;
            }
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


printArray(unsortedArray);
sortArray(unsortedArray);
printArray(unsortedArray);
Console.WriteLine(unsortedArray.Length);