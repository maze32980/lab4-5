namespace ConsoleApp3.Eco;

public class Plant : LivingOrganism, IReproductable, IHuntable
{
    public Plant(int energy, int age, double size, int efficiency)
        : base(energy, age, size)
    {
        PhotosynthesisEfficiency = efficiency;
    }

    public int PhotosynthesisEfficiency { get; set; }

    public void BeHunted()
    {
        Energy -= 15;
    }

    public void Reproduce()
    {
        Energy -= 10;
    }
}