public class Shap
{
    public string Name { get; set; }
    public double Area { get; set; }
    public Shap(string name, double area)
    {
        Name = name;
        Area = area;
    }
}

public class Circle : Shap
{
    public Circle(double Area) : base("Circle", Area){}
}
public class Square : Shap
{
    public Square(double Area) : base("Square", Area){}
}

public class Program
{
    public static void Main(string[] args)
    {
        Shap shap1 = new Shap("Circle", 78.5);
        Shap shap2 = new Shap("Square", 64.0);
        Circle circle = new Circle(78.5);
        Console.WriteLine($"Shape: {circle.Name}, Area: {circle.Area}");
        //
        Shap shap3 = new Circle(78.5);
    }
}