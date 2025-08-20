public class Program
{
    public static void Main(string[] args)
    {
        string SourceFilePath = "E:\\CodeGym\\File\\Source.txt";
        string destinationPath = "E:\\CodeGym\\File\\Destination.txt";
        // bool doesFileExist = File.Exists(destinationPath);
        // File.Copy(SourceFilePath, destinationPath, true);
        // Console.WriteLine($"File copied from {SourceFilePath} to {destinationPath}. File exist: {doesFileExist}");

        // FileInfo sourceFile = new FileInfo(SourceFilePath);
        // sourceFile.CopyTo(destinationPath, true);
        // long fileSize = sourceFile.

        //tạo file mới
        string filePath = "E:\\FileNew";
        //Directory.CreateDirectory(filePath);
        DirectoryInfo directoryInfo = new DirectoryInfo(filePath);
        directoryInfo.Create();
    }
}