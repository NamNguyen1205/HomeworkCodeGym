public class Program
{
    public static void Main(string[] args)
    {
        int[] Arr = { 1000, 23, 3, 8, 21, 100, 220 };
        Console.WriteLine("Mang ban dau la: ");
        PrintArray(Arr);
        Console.WriteLine();

        Console.WriteLine("Nhap so can chen: ");
        int number = Convert.ToInt32(Console.ReadLine());
        //
        Console.WriteLine("Nhap vi tri can chen: ");
        int position = Convert.ToInt32(Console.ReadLine());
        //
        if (position < 0 || position > Arr.Length) return;
        int[] newArr = new int[Arr.Length + 1];
        int i, j;
        for (i = 0, j = 0; i <= Arr.Length; i++)
        {
            if (i == position)
            {
                newArr[i] = number;
            }
            else
            {
                newArr[i] = Arr[j];
                j++;
            }
        }
        PrintArray(newArr);

    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + ", ");
        }
    }
}