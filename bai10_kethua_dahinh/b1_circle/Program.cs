using System;

public class Circle
{
    // Thuộc tính (Fields)
    private double radius;
    private string color;

    // Constructor
    public Circle()
    {
        radius = 1.0;
        color = "red";
    }

    // Constructor có tham số
    public Circle(double radius, string color)
    {
        this.radius = radius;
        this.color = color;
    }

    // Getter/Setter cho radius
    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    // Getter/Setter cho color
    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    // Phương thức tính diện tích
    public double GetArea()
    {
        return Math.PI * radius * radius;
    }

    // Ghi đè ToString để hiển thị thông tin
    public override string ToString()
    {
        return $"Circle: Radius = {radius}, Color = {color}, Area = {GetArea():0.00}";
    }
}

public class Cylinder : Circle
{
    // Thuộc tính chiều cao
    private double height;

    // Constructor mặc định
    public Cylinder() : base()
    {
        height = 1.0;
    }

    // Constructor có tham số
    public Cylinder(double radius, string color, double height) : base(radius, color)
    {
        this.height = height;
    }

    // Getter/Setter cho height
    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    // Phương thức tính thể tích
    public double GetVolume()
    {
        return GetArea() * height; // Diện tích đáy * chiều cao
    }

    // Ghi đè ToString để hiển thị thông tin
    public override string ToString()
    {
        return $"Cylinder: Radius = {Radius}, Color = {Color}, Height = {height}, Volume = {GetVolume():0.00}";
    }
}

class Program
{
    static void Main()
    {
        // Tạo một Circle
        Circle c1 = new Circle(2.5, "blue");
        Console.WriteLine(c1.ToString());

        // Tạo một Cylinder
        Cylinder cyl1 = new Cylinder(2.5, "green", 5.0);
        Console.WriteLine(cyl1.ToString());
    }
}
