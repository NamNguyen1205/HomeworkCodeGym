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
        //Tim phan tu max
        int max = matrix[0, 0];
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                if(matrix[i, j] >= max)
                {
                    max = matrix[i, j];
                }
            }
        }
        Console.WriteLine("Phan tu max la: " + max);

        
    }
}