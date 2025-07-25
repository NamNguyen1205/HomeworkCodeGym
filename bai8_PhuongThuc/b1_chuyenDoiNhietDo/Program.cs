public class Program
{
    public static void Main(string[] args)
    {
        double c, f;
        int choice;
        do
        {
            Console.WriteLine("====================================================");
            Console.WriteLine("Chương trình chuyển đổi nhiệt độ giữa độ C và độ F");
            Console.WriteLine("1. Chuyển đổi từ độ C sang độ F");
            Console.WriteLine("2. Chuyển đổi từ độ F sang độ C");
            Console.WriteLine("3. Thoát");
            Console.Write("Nhập lựa chọn của bạn: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Nhập nhiệt độ (độ C): ");
                    c = Convert.ToDouble(Console.ReadLine());
                    f = CsangF(c);
                    Console.WriteLine($"Nhiệt độ {c}°C tương đương {f}°F");
                    break;
                case 2:
                    Console.Write("Nhập nhiệt độ (độ F): ");
                    f = Convert.ToDouble(Console.ReadLine());
                    c = FsangC(f);
                    Console.WriteLine($"Nhiệt độ {f}°F tương đương {c}°C");
                    break;
                case 3:
                    Console.WriteLine("Thoát chương trình.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng thử lại.");
                    break;
            }
        }
        while (choice != 3);
    }

    public static double CsangF(double c)
    {
        double f = (9.0 / 5) * c + 32;   
        return f;
    }
    public static double FsangC(double f)
    {
        double c = (5.0 / 9) * (f - 32);   
        return c;
    }

    
    
}