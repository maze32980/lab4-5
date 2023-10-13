namespace ConsoleApp3.Eco;

public abstract class LivingOrganism
{
    protected LivingOrganism(int energy, int age, double size)
    {
        Energy = energy;
        Age = age;
        Size = size;
    }

    public int Energy { get; set; }
    public int Age { get; set; }
    public double Size { get; set; }
    public bool IsDead => Energy <= 0;
}