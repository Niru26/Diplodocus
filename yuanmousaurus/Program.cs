Console.Clear();
Console.WriteLine("Homework 9 by Rudakov N.");
//Task 64
// Console.WriteLine("Task 64");

int getInt32Data()
{
    return Convert.ToInt32(Console.ReadLine());
}

void printNumbersRange(int N)
{
    Console.Write($"{N} ");
    if (N > 1)
    {
        printNumbersRange(N - 1);
    }
}

Console.WriteLine("Enter N range:");
int range = getInt32Data();
printNumbersRange(range);
Console.WriteLine(' ');
Console.WriteLine("End task 64");
Console.WriteLine(' ');
// //Task 66
Console.WriteLine("Task 66");
Console.WriteLine("Enter N range:");
int rangeStart = getInt32Data();
Console.WriteLine("Enter M range:");
int rangeFinish = getInt32Data();

int findSumInRange(int start, int finish)
{
    if (start < finish)
    {
        return start + findSumInRange(start + 1, finish);
    }
    return start;
}

Console.WriteLine(findSumInRange(rangeStart, rangeFinish));
Console.WriteLine(' ');
//Task 66
Console.WriteLine("Task 68");
int AkkermanFunction(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (n != 0 && m == 0)
    {
        return AkkermanFunction(n - 1, 1);
    }
    else
    {
        return AkkermanFunction((n - 1), AkkermanFunction(n, (m - 1)));
    }
}

Console.WriteLine("Enter N number:");
int numberN = getInt32Data();
Console.WriteLine("Enter M number:");
int numberM = getInt32Data();
int result = AkkermanFunction(numberN, numberM);
Console.WriteLine($"Function result: {result}");
