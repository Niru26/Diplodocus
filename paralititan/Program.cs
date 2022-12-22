Console.Clear();
Console.WriteLine("Homework 6 by Rudakov N.");
// Task 41
Console.WriteLine("Task 41");
int requestData() {
    return Convert.ToInt32(Console.ReadLine());
}

void countPositiveNumbers() {
    Console.WriteLine("Enter attempts number:");
    int requestNumber = requestData();
    int userPositveNumber = 0;
    Console.WriteLine("Your number is:");
    for(int i = 0; i < requestNumber; i++) {
        int checkNumber = requestData();
        if(checkNumber > 0){
            userPositveNumber = userPositveNumber + 1;
        }
    }
    Console.WriteLine($"There was {userPositveNumber} positive numbers");
}

countPositiveNumbers();
Console.WriteLine("End Task 41");
Console.WriteLine(' ');
// Task 43
double requestDoubleData() {
    return Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Task 43");
void checkCrossing() {
    Console.WriteLine("Enter equation parameters:");
    Console.WriteLine("Enter 1st line b1:");
    double b1 = requestDoubleData();
    Console.WriteLine("Enter 1st line k1:");
    double k1 = requestDoubleData();
    Console.WriteLine("Enter 2nd line b2:");
    double b2 = requestDoubleData();
    Console.WriteLine("Enter 2nd line k2:");
    double k2 = requestDoubleData();
    
    if(k1 == k2) {
        Console.WriteLine("Lines dosn't crossing");
        return;
    }
    double y = (-k2 / k1 * b1 + b2) / (1 - k2 / k1);
    double x = (y - b1) / k1;
    double roundedX = Math.Round(x, 1);
    double roundedY = Math.Round(y, 1);
    Console.WriteLine($"Crossing coordinates: {roundedX}; {roundedY}");
}
checkCrossing();