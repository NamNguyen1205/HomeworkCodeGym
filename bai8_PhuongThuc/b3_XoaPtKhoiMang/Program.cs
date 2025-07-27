public class Program
{
    public static void Main(string[] args)
    {
        int[] arrays = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        FindPT(arrays);
        
    }

    public static void FindPT(int[] arr)
    {
        Console.WriteLine("Nhap phan tu can xoa: ");
        int pt = Convert.ToInt32(Console.ReadLine());
        if (arr == null || arr.Length == 0)
        {
            Console.WriteLine("Mang khong ton tai hoac rong");
            return; // Exit the method if the array is null or empty
        }

        if (!arr.Contains(pt))
        {
            Console.WriteLine("Phan tu khong ton tai trong mang");
            return; // Return an invalid value to indicate failure
        }
        else
        {
            int[] newArr = new int[arr.Length - 1];
            int index = 0;
            foreach (int num in arr)
            {
                if (num != pt)
                {
                    newArr[index++] = num;
                }
            }
            Console.WriteLine("Mang sau khi xoa phan tu: " + string.Join(", ", newArr));
        }
    }
}