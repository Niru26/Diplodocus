Console.Clear();
//Task 2
int requestData() {
    return Convert.ToInt32(Console.ReadLine());
}

void showMax() {
    int maximumValue = requestData();
    int minimumValue = requestData();
    
    if (minimumValue > maximumValue) {
        maximumValue = minimumValue;
        minimumValue = maximumValue;
    }
    Console.WriteLine($"Maximum value is {maximumValue} and minimum value is {minimumValue}");
}

showMax();





