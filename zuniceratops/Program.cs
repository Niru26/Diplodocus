Console.Clear();
//Task 2
int requestData() {
    return Convert.ToInt32(Console.ReadLine());
}

// int inputData = requestData();
// Console.WriteLine(inputData);
// int inputData = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(inputData);
int showMax() {
    int inputData1 = requestData();
    int inputData2 = requestData();
    if (inputData1 > inputData2) {
        return inputData1;
    }
    return inputData2;
}

int maxValue = showMax();
Console.WriteLine(maxValue);



