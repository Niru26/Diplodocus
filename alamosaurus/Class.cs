public class Person 
{
    public string LastName;
    public string FirstName;

    public void Introduce ()
    {
        Console.WriteLine("My name is " + FirstName + " " + LastName);
    }
}

public class Calculator 
{
    public int Add (int a, int b) 
    {
        return a + b;
    }
}