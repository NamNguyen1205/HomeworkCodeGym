public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        a = Math.Abs(a);
        b = Math.Abs(b);
        if (a == 0 || b == 0)
            Console.WriteLine("ko co UCLN");

        while (a != b)
        {
            if (a > b)
                a = a - b;
            else
                b = b - a;
        }

        Console.WriteLine("UCLN: " + a);
    }
}