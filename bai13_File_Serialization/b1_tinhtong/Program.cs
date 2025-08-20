
public class Program
{
    static void Main(string[] args)
    {
        string path = "E:\\CodeGym\\HomeworkCodeGym\\bai13_File_Serialization\\b1_tinhtong\\file2.txt";
        Console.WriteLine("File path: " + path);
        //ReadTextFileExample example = new ReadTextFileExample();
        ReadTextFile(path);
    }
    
    static void ReadTextFile(string filePath)
    {
        try
        {
            FileInfo file = new FileInfo(filePath);
            if (!file.Exists)
            {
                throw new FileNotFoundException();
            }

            StreamReader reader = new StreamReader(filePath);
            string line = "";
            int sum = 0;
            while((line = reader.ReadLine()) != null) 
            {
                Console.WriteLine(line);
                sum += Int32.Parse(line);
            }
            reader.Close();
            Console.WriteLine("Total: " + sum);
        }
        catch (System.Exception)
        {
            Console.Error.WriteLine("File not found or invalid content");
        }
    }
}
