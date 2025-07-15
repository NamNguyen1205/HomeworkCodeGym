public class Program
{
    public static void Main(string[] args)
    {
        int year;
        bool isLeapYear = false;

        Console.WriteLine("Nhap nam: ");
        year = Convert.ToInt32(Console.ReadLine());

        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    isLeapYear = true;
                }
            }
            else
            {
                isLeapYear = true;
            }
        }

        if (isLeapYear)
        {
            Console.WriteLine("{0} is a leap year", year);
        }
        else
        {
            Console.WriteLine("{0} is NOT a leap year", year);
        }
    }
}