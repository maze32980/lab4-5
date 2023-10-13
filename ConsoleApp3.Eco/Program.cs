using ConsoleApp3.Eco;

var ecoSystem = new Ecosystem();

for (var i = 0; i < 3; i++)
    ecoSystem.AddOrganism(new Carnivore(100, 2, 15, 10));

for (var i = 0; i < 5; i++)
    ecoSystem.AddOrganism(new Herbivore(90, 1, 10, 8));

for (var i = 0; i < 7; i++)
    ecoSystem.AddOrganism(new Tree(80, 20, 200, 80));

for (var i = 0; i < 10; i++)
    ecoSystem.AddOrganism(new Grass(50, 1, 2, 75));

for (var day = 1; day <= 5; day++)
{
    ecoSystem.SimulateDay();

    Console.WriteLine($"Day {day}:");
    Console.WriteLine($"Number of Carnivores: {ecoSystem.Organisms.Count(o => o is Carnivore)}");
    Console.WriteLine($"Number of Herbivores: {ecoSystem.Organisms.Count(o => o is Herbivore)}");
    Console.WriteLine($"Number of Trees: {ecoSystem.Organisms.Count(o => o is Tree)}");
    Console.WriteLine($"Number of Grasses: {ecoSystem.Organisms.Count(o => o is Grass)}");
    Console.WriteLine("-------------------------------");
}