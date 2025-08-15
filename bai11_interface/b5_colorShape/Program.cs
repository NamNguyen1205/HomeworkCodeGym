using System;

public class Square : IColorable
{
    // Thuộc tính (Fields)
    private double dai;
    private double rong;
    private string color;

    // Constructor có tham số
    public Square(double dai, double rong, string color)
    {
        this.dai = dai;
        this.rong = rong;
        this.color = color;
    }

    // Phương thức tính diện tích
    public double GetArea()
    {
        return dai * rong;
    }

    // Ghi đè ToString để hiển thị thông tin
    public override string ToString()
    {
        return $"Square: dai = {dai}, rong = {rong}, Area = {GetArea()}";
    }
    public void HowToColor()
    {
        Console.WriteLine($"hinh vuong co mau {color}");
    }
}


class Program
{
    static void Main()
    {
        
        Square[] squares = new Square[]
        {
            new Square(10,20,"hong"),
            new Square(5,6,"den")
        };

        foreach (Square s in squares)
        {
            Console.WriteLine(s.ToString());
            s.HowToColor();
        }
    }
}
