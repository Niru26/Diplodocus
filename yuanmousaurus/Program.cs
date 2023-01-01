Console.Clear();
Console.WriteLine("Homework 9 by Rudakov N.");
//Task 64
Console.WriteLine("Task 64");

int getInt32Data()
{
    return Convert.ToInt32(Console.ReadLine());
}

// void printNumbersRange(int N)
// {
//     Console.Write($"{N} ");
//     if (N > 1)
//     {
//         printNumbersRange(N - 1);
//     }
// }

// Console.WriteLine("Enter N range:");
// int range = getInt32Data();
// printNumbersRange(range);
// Console.WriteLine("End task 64");
//Task 66
Console.WriteLine("Task 66");
Console.WriteLine("Enter N range:");
int rangeStart = getInt32Data();
int rangeFinish = getInt32Data();

int findSumInRange(int start, int finish, int summary)
{
    if (start < finish)
    {
        summary = summary + start;
        findSumInRange(start + 1, finish, summary);
    }
    return summary;
}

Console.WriteLine(findSumInRange(rangeStart, rangeFinish, 1));
