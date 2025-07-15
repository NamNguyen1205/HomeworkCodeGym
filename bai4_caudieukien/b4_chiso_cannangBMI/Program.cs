public class Program
{
    public static void Main(string[] args)
    {
        double height;
        double weight;

        Console.WriteLine("Nhap chieu cao: ");
        height = float.Parse(Console.ReadLine());

        Console.WriteLine("Nhap can nang: ");
        weight = float.Parse(Console.ReadLine());

        double bmi = weight / Math.Pow(height, 2);
        bmi = Math.Round(bmi, 1);
        Console.Write("BMI: " + bmi);
        if (bmi < 18)
            Console.WriteLine(" Underweight");
        else if (bmi < 25.0)
            Console.WriteLine(" Normal");
        else if (bmi < 30.0)
            Console.WriteLine(" Overweight");
        else
            Console.WriteLine(" Obese");
    }
}