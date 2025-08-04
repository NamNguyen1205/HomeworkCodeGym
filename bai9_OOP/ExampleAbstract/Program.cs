public abstract class BaseClass
{
    public abstract void AbstractMethod();
}

public class DerivedClass : BaseClass
{
    public override void AbstractMethod()
    {
        Console.WriteLine("Abstract method implemented in DerivedClass.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        
    }
}