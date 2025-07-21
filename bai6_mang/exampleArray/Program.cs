public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = new int[5];

        numbers[0] = 2;
        numbers[1] = 8;
        numbers[2] = 9;
        numbers[3] = 1;
        numbers[4] = 7;

        int total = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            total += numbers[i];
        }
        Console.WriteLine("tong cac phan tu cua mang la: ");
        Console.WriteLine(total);
    }
}