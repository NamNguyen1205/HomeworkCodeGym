public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double MathScore { get; set; }
    public double EnglishScore { get; set; }

    // Constructor to initialize all properties
    public Student(string name, int age, double mathScore, double englishScore)
    {
        Name = name;
        Age = age;
        MathScore = mathScore;
        EnglishScore = englishScore;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student("John Doe", 20, 85.5, 90.0);
        
        Console.WriteLine($"Name: {student1.Name} Age: {student1.Age} Math Score: {student1.MathScore} English Score: {student1.EnglishScore}");
    }
}