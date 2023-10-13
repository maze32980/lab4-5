namespace ConsoleApp3.Traffic;

public class Vehicle : IDriveable
{
    public enum VehicleType
    {
        Car,
        Truck,
        Bus,
        Motorcycle
    }

    public string Model { get; set; }
    public VehicleType Type { get; set; }

    public void Move()
    {
        Console.WriteLine($"Vehicle {Model} of type {Type} is moving.");
    }

    public void Stop()
    {
        Console.WriteLine($"Vehicle {Model} of type {Type} has stopped.");
    }
}