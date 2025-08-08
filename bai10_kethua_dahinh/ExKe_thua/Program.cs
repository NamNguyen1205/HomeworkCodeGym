public class Vehicle
{
    public string Name { get; set; }
    public int Speed { get; set; }

    public Vehicle(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Vehicle Name: {Name}, Speed: {Speed} km/h");
    }
    protected virtual void StartEngine()
    {
        Console.WriteLine($"{Name} engine started.");
    }
}

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
    public Car(string name, int speed, int numberOfDoors) : base(name, speed)
    {
        NumberOfDoors = numberOfDoors;
    }
    public void DisplayCarInfo()
    {
        DisplayInfo();
        Console.WriteLine($"Number of Doors: {NumberOfDoors}");
    }
    protected override void StartEngine()
    {
        Console.WriteLine($"{Name} car engine started with a roar!");
    }
}
public class CarRed : Car
{
    public string Color { get; set; }
    public CarRed(string name, int speed, int numberOfDoors, string color) : base(name, speed, numberOfDoors)
    {
        Color = color;
    }
    public void DisplayCarRedInfo()
    {
        DisplayCarInfo();
        Console.WriteLine($"Color: {Color}");
    }
    public override void StartEngine()
    {
        Console.WriteLine($"{Name} red car engine started with a loud roar!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Vehicle myVehicle = new Vehicle("Generic Vehicle", 80);
        myVehicle.DisplayInfo();
        myVehicle.StartEngine();

        Car myCar = new Car("Sports Car", 200, 2);
        myCar.DisplayCarInfo();
        myCar.StartEngine();
    }
}