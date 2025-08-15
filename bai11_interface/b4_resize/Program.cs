using System;

public class Circle : IResizeable
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
    public void resize(double percent)
    {
        radius += radius * (percent / 100);
        Console.WriteLine("circle scale co kich thuoc la: " + radius);
    }
}


class Program
{
    static void Main()
    {
        // Tạo một Circle
        Circle c1 = new Circle(100, "blue");
        Console.WriteLine(c1.ToString());
        Circle c2 = new Circle(1, "red");
        Console.WriteLine(c2.ToString());

        c1.resize(10);
    }
}
