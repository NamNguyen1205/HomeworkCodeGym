public class Program
{
    public static void Main(string[] args)
    {
        int[,] matrix = new int[3, 3]
        {
            { 11, 20, 3 },
            { 4, 5, 6 },
            { 7, 8, 19 }
        };
        //Nhap ma tran
        // for (var i = 0; i < matrix.GetLength(0); i++)
        // {
        //     for (var j = 0; j < matrix.GetLength(1); j++)
        //     {
        //         Console.Write($"Nhap g/tri hang {i} cot {j}: ");
        //         matrix[i, j] = Convert.ToInt32(Console.ReadLine());
        //     }
        // }
        // Console.WriteLine("");
        //In ra ma tran da nhap
        //Console.WriteLine("Ma tran da nhap la: ");

        Console.Write("cac so nguyen to trong ma tran la: ");
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                if (IsPrime(matrix[i, j]))
                {
                    Console.Write(matrix[i, j] +", ");
                }

            }
        }
        
    }
    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}