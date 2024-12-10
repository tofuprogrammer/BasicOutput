namespace Task_2;

class Program
{
    static void Main(string[] args)
    {
        var currentYear = DateTime.Now.Year;
        var birthYear = 2006;
        var age = currentYear - birthYear;
        Console.WriteLine("Hello, Sam!");
        Console.Write("Your age is ");
        Console.Write(age);
        Console.WriteLine(".");
    }
}