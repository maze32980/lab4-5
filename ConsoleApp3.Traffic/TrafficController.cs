namespace ConsoleApp3.Traffic;

public class TrafficController
{
    private readonly Road road;
    private readonly List<Vehicle> vehicles = new();

    public TrafficController(Road road)
    {
        this.road = road;
    }

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
        road.CurrentTraffic += 1;
        Console.WriteLine($"Vehicle {vehicle.Model} added to the road.");
    }

    public void RemoveVehicle(Vehicle vehicle)
    {
        vehicles.Remove(vehicle);
        road.CurrentTraffic -= 1;
        Console.WriteLine($"Vehicle {vehicle.Model} removed from the road.");
    }

    public void UpdateTraffic()
    {
        Console.WriteLine($"Updated traffic on the road. Current vehicles: {road.CurrentTraffic}");
    }
}