using System;

public class Point2D
{
    // Thuộc tính
    private float x = 0.0f;
    private float y = 0.0f;

    // Constructor
    public Point2D() { }

    // Constructor có tham số
    public Point2D(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    
    public float GetX()
    {
        return x;
    }
    public void SetX(float x)
    {
        this.x = x;
    }

    // Getter và Setter cho y
    public float GetY()
    {
        return y;
    }
    public void SetY(float y)
    {
        this.y = y;
    }

    // Set cả x và y
    public void SetXY(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    // Lấy cả x và y dưới dạng mảng
    public float[] GetXY()
    {
        return new float[] { x, y };
    }

    // Ghi đè ToString
    public override string ToString()
    {
        return $"({x}, {y})";
    }
}

public class Point3D : Point2D
{
    // Thuộc tính z
    private float z = 0.0f;

    // Constructor mặc định
    public Point3D() : base() { }

    // Constructor có tham số
    public Point3D(float x, float y, float z) : base(x, y)
    {
        this.z = z;
    }

    // Getter và Setter cho z
    public float GetZ()
    {
        return z;
    }
    public void SetZ(float z)
    {
        this.z = z;
    }

    // Set cả x, y, z
    public void SetXYZ(float x, float y, float z)
    {
        SetXY(x, y); // Gọi phương thức của lớp cha
        this.z = z;
    }

    // Lấy x, y, z dưới dạng mảng
    public float[] GetXYZ()
    {
        return new float[] { GetX(), GetY(), z };
    }

    // Ghi đè ToString
    public override string ToString()
    {
        return $"({GetX()}, {GetY()}, {z})";
    }
}

class Program
{
    static void Main()
    {
        // Test Point2D
        Point2D p2 = new Point2D(3.5f, 5.5f);
        Console.WriteLine("Point2D: " + p2.ToString());

        // Test Point3D
        Point3D p3 = new Point3D(2.2f, 4.4f, 6.6f);
        Console.WriteLine("Point3D: " + p3.ToString());

        // Set giá trị mới cho p3
        p3.SetXYZ(1.1f, 2.2f, 3.3f);
        Console.WriteLine("Point3D sau khi SetXYZ: " + p3.ToString());

        // Lấy mảng XYZ
        float[] coords = p3.GetXYZ();
        Console.WriteLine($"Array: [{coords[0]}, {coords[1]}, {coords[2]}]");
    }
}
