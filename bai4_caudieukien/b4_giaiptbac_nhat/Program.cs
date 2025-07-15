
public class Program
{
    public static void Main(string[] args)
    {
        //pt bac 1: ax + b = 0
        Console.WriteLine("Nhap gia tri a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap gia tri b:");
        double b = Convert.ToDouble(Console.ReadLine());
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Pt vo so nghiem");
            }
            else
            {
                Console.WriteLine("Pt vo nghiem");
            }
        }
        else
        {
            double x = -b / a;
            System.Console.WriteLine("phuong trinh co nghiem la: " + x);
        }
    }
}