
class Circle
{
    public double Radius { get; set; }
    public Circle(double r)
    {
        Radius = r;
    }
    public virtual void Area()
    {
        Console.WriteLine("Calculating area of Circle");
    }
}

public class Cylinder : Circle
{
    public double Height { get; set; }
    public Cylinder(double r, double h) : base(r)
    {
        Height = h;
    }
    public override void Area()
    {
        Console.WriteLine("Calculating area of Cylinder");
    }
}

public class Program
    {
        public static void Main(string[] args)
        {
            Circle cyl = new Cylinder(5, 10);
            cyl.Area();
        }
    }