namespace ConsoleApp3.Eco;

public class Ecosystem
{
    public List<LivingOrganism> Organisms { get; } = new();

    public void AddOrganism(LivingOrganism organism)
    {
        Organisms.Add(organism);
    }

    public void SimulateDay()
    {
        foreach (var organism in Organisms)
        {
            if (organism is IPredator predator)
            {
                var target = FindHuntableFor(predator);
                if (target != null) predator.Hunt(target);
            }

            if (organism is IReproductable reproducable) reproducable.Reproduce();
        }

        Organisms.RemoveAll(o => o.IsDead);
    }

    private IHuntable FindHuntableFor(IPredator predator)
    {
        return Organisms.FirstOrDefault(o => o is IHuntable && o != predator) as IHuntable;
    }
}