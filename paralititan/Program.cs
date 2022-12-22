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
Console.WriteLine("Task 43");