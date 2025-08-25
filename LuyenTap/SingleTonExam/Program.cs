public class Program
{
    public static void Main(string[] args)
    {
        var config = Singleton<config>.Instance;
        config.AppName = "Myappplication";
        //
        var logger = Singleton<logger>.Instance;
        logger.Log($"Application Name:  {config.AppName}");
    }
}