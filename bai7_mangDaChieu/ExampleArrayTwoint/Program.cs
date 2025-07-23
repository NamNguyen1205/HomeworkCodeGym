public class Program
{
    public static void Main(string[] args)
    {
        int[,] matrix = new int[4, 3]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {10, 11, 12},
        };
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + ", ");
            }
            Console.WriteLine();
        }

        //tinh tong dg cheo cua matrix
        int sum2 = 0;
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == j) sum2 += matrix[i, j];
            }
            Console.WriteLine();
        }
        Console.WriteLine("tong duong cheo la: " + sum2);
        //////////////
    }
}