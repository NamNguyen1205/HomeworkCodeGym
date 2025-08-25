public class Program
{
    public static void Main(string[] args)
    {
        Repository<Product> repository = new Repository<Product>();
        repository.Add(new Product { Name = "Laptop", Price = 900 });
        repository.Add(new Product { Name = "Smartphone", Price = 10 });
        repository.Add(new Product { Name = "Tablet", Price = 990 });
        repository.Add(new Product { Name = "Book", Price = 200 });

        foreach (var item in repository.GetAll())
        {
            Console.WriteLine(item);
        }
    }
}