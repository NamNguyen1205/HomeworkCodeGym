public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle()
    {

    }
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double GetArea()
    {
        return Width * Height;
    }
    public double GetPerimeter()
    {
        return 2 * (Width + Height);
    }
    public string Display()
    {
        return $"Rectangle: Width = {Width}, Height = {Height}, Area = {GetArea()}, Perimeter = {GetPerimeter()}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(5, 10);
        Console.WriteLine(rectangle.Display());
    }
}