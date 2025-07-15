public class Program
{
    public static void Main(string[] args)
    {
        int rate = 23000;

        Console.WriteLine("Nhap USD muon chuyen doi: ");
        int usd = Convert.ToInt32(Console.ReadLine());

        int vnd = rate*usd;
        Console.WriteLine("VND tuong ung la: " + vnd);

    }
}