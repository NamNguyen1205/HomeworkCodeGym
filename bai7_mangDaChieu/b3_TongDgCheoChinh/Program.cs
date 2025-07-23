public class Program
{
    public static void Main(string[] args)
    {
        int[,] matrix = new int[3, 3];
        //Nhap ma tran
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"Nhap g/tri hang {i} cot {j}: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("");
        //In ra ma tran da nhap
        Console.WriteLine("Ma tran da nhap la: ");
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + ", ");
            }
            Console.WriteLine();
        }
        //Tong duong cheo chinh
        int sum = 0;
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == j) sum += matrix[i, j];
            }
        }
        Console.Write("tong duong cheo chinh la: " + sum);

        
    }
}