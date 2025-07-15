public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        string? name = Convert.ToString(Console.ReadLine()); //co the null
        Console.WriteLine("Hello: " + name);
    }
}