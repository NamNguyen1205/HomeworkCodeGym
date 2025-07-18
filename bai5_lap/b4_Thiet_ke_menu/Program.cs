public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap vao 1 so: ");
        int choice = -1;
        while (choice != 0)
        {
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Draw the triangle");
                    Console.WriteLine("*");
                    Console.WriteLine("**");
                    Console.WriteLine("***");
                    Console.WriteLine("****");
                    Console.WriteLine("*****");
                    break;
                case 2:
                    Console.WriteLine("Draw the square");
                    Console.WriteLine("****");
                    Console.WriteLine("****");
                    Console.WriteLine("****");
                    Console.WriteLine("****");
                    break;
                case 3:
                    Console.WriteLine("Draw the rectangle");
                    Console.WriteLine("****");
                    Console.WriteLine("****");
                    Console.WriteLine("****");
                    Console.WriteLine("****");
                    Console.WriteLine("****");
                    Console.WriteLine("****");
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("nhap lai");
                    break ;
            }
        }
    }
}