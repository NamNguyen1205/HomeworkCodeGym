public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1000, 23, 3, 8, 21, 100, 220 };
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (max <= numbers[i])
            {
                max = numbers[i];
            }
        }
        Console.WriteLine("So lon nhat la: " + max);
    }
}