namespace ConsoleApp3.Eco;

public class Animal : LivingOrganism, IPredator, IReproductable, IHuntable
{
    public Animal(int energy, int age, double size, int speed)
        : base(energy, age, size)
    {
        Speed = speed;
    }

    public int Speed { get; set; }

    public void BeHunted()
    {
        Energy -= 20;
    }

    public virtual void Hunt(IHuntable target)
    {
        Energy -= 10;
        target.BeHunted();
    }

    public void Reproduce()
    {
        Energy -= 20;
    }
}