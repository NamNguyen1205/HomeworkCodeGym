public class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("**");
        // Console.WriteLine("***");
        // Console.WriteLine("****");
        // Console.WriteLine("*****");
        // for (int i = 1; i <= 5; i++)
        // {
        //     for (int j = 1; j <= i; j++)
        //     {
        //         Console.Write("* ");
        //     }
        //     Console.WriteLine("");
        // }
        Console.WriteLine("Ban muon in hinh gi?");
        Console.WriteLine("1 - hinh chu nhat");
        Console.WriteLine("2 - hinh tam giac");
        int select = Convert.ToInt32(Console.ReadLine());
        if (select == 1)
        {
            InHCN();
        }
        else if (select == 2)
        {
            InTamGiac();
        }
        else
        {
            Console.WriteLine("lua chon ko ton tai");
        }
    }
    public static void InHCN()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("");
        }
    }
    public static void InTamGiac()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("");
        }
    }
}