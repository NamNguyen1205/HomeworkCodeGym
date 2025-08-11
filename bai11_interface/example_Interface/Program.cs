public class Player : IDamagable, IDestroy
{
    private int health;
    public Player(int initialHealth)
    {
        health = initialHealth;
    }
    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health < 0) health = 0;
    }
    public void Dead()
    {
        if (health <= 0)
        {
            Console.WriteLine("Player is dead");
        }
        Destroy();
    }

    public void Destroy()
    {
        Console.WriteLine("Player has been destroyed");
        health = 0;
    }

    public int Health => health;
}



public class Program
{
    static void Main(string[] args)
    {
        Player player = new Player(100);
        Console.WriteLine($"Initial Health: {player.Health}");

        player.TakeDamage(10);
        Console.WriteLine($"Initial Health: {player.Health}");

        player.Dead();
        Console.WriteLine($"Initial Health: {player.Health}");
    }
}