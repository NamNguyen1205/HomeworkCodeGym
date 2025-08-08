public class Fan
{
    const int SLOW = 1;
    const int MEDIUM = 2;
    const int FAST = 3;
    private int speed;
    private bool on;
    private double radius;
    private string color;
    //getter and setter
    public int Speed { get { return speed; } set { speed = value; } }
    public bool On { get { return On; } set { On = value; } }
    public string Color { get { return color; } set { color = value; } }

    public Fan()
    {
        speed = SLOW;
        on = false;
        radius = 5.0;
        color = "blue";
    }
    public Fan(int speed, bool on, double radius, string color)
    {
        this.speed = speed;
        this.on = on;
        this.radius = radius;
        this.color = color;
    }

    public void FanStatus()
    {
        if (on)
        {
            Console.WriteLine($"Fan is ON, Speed: {speed}, Radius: {radius} Color: {color}");
        }
        else
        {
            Console.WriteLine($"Fan is OFF, Radius: {radius} Color: {color}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Fan fan1 = new Fan(3, true, 10.0, "yellow");
        fan1.FanStatus();
    }
}