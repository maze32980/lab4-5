namespace ConsoleApp3.Eco;

public class Carnivore : Animal
{
    public Carnivore(int energy, int age, double size, int speed)
        : base(energy, age, size, speed)
    {
    }

    public override void Hunt(IHuntable target)
    {
        if (target is Animal)
            base.Hunt(target);
    }
}