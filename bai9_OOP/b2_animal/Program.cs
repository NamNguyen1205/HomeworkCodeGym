public abstract class Animal
 {
     protected string Weight { get; set; }
     protected string Height { get; set; }

     public Animal(string weight, string height)
     {
         this.Weight = weight;
         this.Height = height;
     }
     public abstract void PrintInfo();
 }

class Cat : Animal
{
    private string Name { get; set; }
    public Cat(string Weight, string Height, string name) : base(Weight, Height)
    {
        Name = name;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Cat: Name = {Name}, Weight = {Weight}, Height = {Height}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Cat cat = new Cat("4kg", "30cm", "Mimi");
        cat.PrintInfo();
    }
}