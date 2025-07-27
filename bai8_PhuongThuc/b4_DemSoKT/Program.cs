public class Program
{
    public static void Main(string[] args)
    {
        string str = "khong co gi la kho";
        int count = FindChar(str, 'l');
        Console.WriteLine($"So lan xuat hien cua 'o' trong chuoi: {count}");
    }

    public static int FindChar(string str, char c)
    {
        int count = 0;
        foreach (char ch in str)
        {
            if (ch == c)
            {
                count++;
            }
        }
        return count;
    }
    
}