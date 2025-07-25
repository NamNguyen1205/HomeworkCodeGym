public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap so nguyen a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so nguyen b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int max = Max(a, b);
        PrintMax(a,b);
    }

    public static int Max(int a, int b)
    {
        return a > b ? a : b;
    }
    public static void PrintMax(int a, int b)
    {
        Console.WriteLine("So lon nhat la: " + Max(a, b));
    }
}