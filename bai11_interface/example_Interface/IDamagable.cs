
public interface IDamagable
{
    void TakeDamage(int amount);
    int Health { get; }
}

public class Player : IDamagable
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
    void Dead()
    {
        if (health <= 0)
        {
            Console.WriteLine("Player is dead");
        }
    }

    public int Health => health;
}
