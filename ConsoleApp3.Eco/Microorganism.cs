namespace ConsoleApp3.Eco;

public class Microorganism : LivingOrganism
{
    public Microorganism(int energy, int age, double size, string type)
        : base(energy, age, size)
    {
        BacterialType = type;
    }

    public string BacterialType { get; set; }
}