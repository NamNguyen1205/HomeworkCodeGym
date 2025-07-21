public class Program
{
    public static void Main(string[] args)
    {
        string[] students = { "nam", "thanh", "nga", "thien", "hung", "long", "hoa", "mai", "manh", "kien" };
        
        Console.WriteLine("ten muon tim la: ");
        string? cantim = Console.ReadLine();

        for (int i = 0; i < students.Length; i++)
        {
            if (cantim == students[i])
            {
                Console.WriteLine("vi tri thu: " + i);
                
                break;
            }
            if (i == students.Length - 1)
            {
                Console.WriteLine("ko co ten trong danh sach");
            }
        }
    }
}