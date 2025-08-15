public abstract class Animal
{
    public abstract string MakeSound();
}

public class Tiger : Animal
{
    public override string MakeSound()
    {
        return "Tiger: roarrrrr!";
    }
}

public class Chicken : Animal
{
    public override string MakeSound()
    {
        return "Chicken: cluck-cluck!";
    }
}

public class Program
{
  static void Main(string[] args)
  {
    Animal[] animals = new Animal[2];
    animals[0] = new Tiger();
    animals[1] = new Chicken();

    foreach (Animal animal in animals)
    {
      Console.WriteLine(animal.MakeSound());
    }
  }
}