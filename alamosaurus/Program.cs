// int Add(int a, int b) {
//     return a + b;
// } 
// int result = Add (2, 3);
// Console.WriteLine(result);


internal class Program
{
      private static void Main(string[] args)
    {
        Console.Clear();

        Person john = new Person();
        john.FirstName = "Tomotoli";
        john.LastName = "Kababic";
        john.Introduce();

        Calculator calculator = new Calculator();
        double result = calculator.Add(2, 3);
        Console.WriteLine(result);
    }

}