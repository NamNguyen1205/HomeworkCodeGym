
public class Program
{
    public static void Main(string[] args)
    {
        string[,] map = {
            {"*", ".", ".", "."},
            {".", ".", ".", "."},
            {".", "*", ".", "."},
            {".", ".", ".", "."}
        };
        int row = map.GetLength(0);
        int col = map.GetLength(1);
        string[,] mapResult = new string[row, col];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (map[i, j] == "*")
                {
                    mapResult[i, j] = "*";
                }
                else
                {

                    int[,] neighboringMines = {
                        {i - 1, j - 1},
                        { i - 1, j},
                        { i - 1, j + 1},
                        {i, j - 1},
                        { i, j + 1},
                        {i + 1, j - 1},
                        { i + 1, j},
                        { i + 1, j + 1}
                    };
                    int dem = 0;

                    for (int k = 0; k < neighboringMines.GetLength(0); k++)
                    {
                        int neighborRow = neighboringMines[k, 0];//giá trị i
                        int neighborCol = neighboringMines[k, 1];//giá trị j
                        // Kiểm tra xem hàng xóm có nằm trong phạm vi của ma trận không
                        // các Th ko là hàng xóm: i-1 mà min -> i-1 < 0, i+1 mà max -> i+1 == row || i+1 >= row
                        bool isNotNeighbor = neighborRow < 0 || neighborRow == row ||
                                             neighborCol < 0 || neighborCol == col;
                        if (isNotNeighbor)
                        {
                            continue; //ko phải là hàng xóm thì bỏ qa vòng for hiện tại
                        }
                        if (map[neighborRow, neighborCol] == "*")
                        {
                            dem++; // Tăng biến đếm nếu hàng xóm là mìn
                        }
                    }
                    mapResult[i, j] = dem.ToString();

                }
            }
            Console.WriteLine();
        }

        // In ra map kết quả
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(mapResult[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
