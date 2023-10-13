namespace ConsoleApp3.Traffic;

public class Simulation
{
    private readonly List<Road> roads = new();
    private readonly List<TrafficController> trafficControllers = new();

    public void AddRoad(Road road)
    {
        roads.Add(road);
        trafficControllers.Add(new TrafficController(road));
    }

    public void Start()
    {
        Console.WriteLine("Starting the simulation.");
    }

    public void Update()
    {
        Console.WriteLine("Updating the simulation.");
        foreach (var controller in trafficControllers) controller.UpdateTraffic();
    }
}