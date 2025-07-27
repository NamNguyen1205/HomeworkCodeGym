public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 5, 30, 81, 200, 44 };
        int minValue = FindMin(numbers);
        Console.WriteLine("The minimum value is: " + minValue);
    }

    public static int FindMin(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            Console.WriteLine("Mang ko ton tai hoac rong");
        }

        int min = arr[0];
        foreach (int num in arr)
        {
            if (num < min)
            {
                min = num;
            }
        }
        return min;
    }
}