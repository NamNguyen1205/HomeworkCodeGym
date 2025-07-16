public class Program
{
    public static void Main(string[] args)
    {
        double money = 1.0;
        int month = 1;
        double interest_rate = 1.0;
        Console.WriteLine("nhap so tien gui: ");
        money = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("nhap so thang gui: ");
        month = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Nhap lai suat");
        interest_rate = Convert.ToDouble(Console.ReadLine());

        double tongLai = 0;
        for (int i = 0; i < month; i++)
        {
            tongLai = money * (interest_rate / 100) / 12 * month;
        }
        Console.WriteLine("tong lai la: " + tongLai);
    }
}