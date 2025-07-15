public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap thang ban muon dem ngay: ");
        int month = Convert.ToInt32(Console.ReadLine());

        string daysInMonth; 
        switch (month)
        {
            case 2:
                daysInMonth = "28 or 29";
                break;
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                daysInMonth = "31";
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                daysInMonth = "30";
                break;
            default:
                daysInMonth = "";
                break;
        }

        if (daysInMonth != "")
        {
            Console.WriteLine("Thang {0} co {1} ngay!", month, daysInMonth);
        }
        else
        {
           Console.WriteLine("Thang ko ton tai!");
        }
    }
}