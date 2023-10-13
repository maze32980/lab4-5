namespace ConsoleApp3.Eco;

public class Herbivore : Animal
{
    public Herbivore(int energy, int age, double size, int speed)
        : base(energy, age, size, speed)
    {
    }

    public override void Hunt(IHuntable target)
    {
        if (target is Plant)
            base.Hunt(target);
    }
}