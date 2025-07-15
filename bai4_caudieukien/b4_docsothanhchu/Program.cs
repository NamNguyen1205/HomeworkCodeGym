public class Program()
{
    public static void Main(string[] args)
    {
        //Đọc số thành chữ
        Console.WriteLine("Hay nhap mot so");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 0 && number <= 9)
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;

            }
        }
        else if (number >= 10 && number <= 19)
        {
            switch (number)
            {
                case 10:
                    Console.Write("ten");
                    break;
                case 11:
                    Console.Write("elevent");
                    break;
                case 12:
                    Console.Write("twelve");
                    break;
                case 13:
                    Console.Write("thirteen");
                    break;
                case 14:
                    Console.Write("fourteen");
                    break;
                case 15:
                    Console.Write("fifteen");
                    break;
                case 16:
                    Console.Write("sixteen");
                    break;
                case 17:
                    Console.Write("seventeen");
                    break;
                case 18:
                    Console.Write("eighteen");
                    break;
                case 19:
                    Console.Write("nineteen");
                    break;
            }
        }
        else if (number >= 20 && number <= 99)
        {
            int chuc = number / 10;
            int donvi = number % 10;
            switch (chuc)
            {
                case 2:
                    Console.Write("twenty ");
                    break;
                case 3:
                    Console.Write("thirty ");
                    break;
                case 4:
                    Console.Write("fourty ");
                    break;
                case 5:
                    Console.Write("fifty ");
                    break;
                case 6:
                    Console.Write("sixty ");
                    break;
                case 7:
                    Console.Write("seventy ");
                    break;
                case 8:
                    Console.Write("eighty ");
                    break;
                case 9:
                    Console.Write("ninety ");
                    break;
            }
            switch (donvi)
            {
                case 1:
                    Console.Write("one");
                    break;
                case 2:
                    Console.Write("two");
                    break;
                case 3:
                    Console.Write("three");
                    break;
                case 4:
                    Console.Write("four");
                    break;
                case 5:
                    Console.Write("five");
                    break;
                case 6:
                    Console.Write("six");
                    break;
                case 7:
                    Console.Write("seven");
                    break;
                case 8:
                    Console.Write("eight");
                    break;
                case 9:
                    Console.Write("nine");
                    break;
            }
        }
    }
}