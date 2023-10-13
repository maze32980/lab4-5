namespace ConsoleApp3.Traffic;

internal class Program
{
    private static void Main()
    {
        var simulation = new Simulation();

        var mainRoad = new Road { Length = 100, Width = 10, Lanes = 2, CurrentTraffic = 0 };
        simulation.AddRoad(mainRoad);

        simulation.Start();

        var car1 = new Vehicle { Model = "Toyota", Type = Vehicle.VehicleType.Car };
        var bus1 = new Vehicle { Model = "Volvo", Type = Vehicle.VehicleType.Bus };

        var mainRoadController = new TrafficController(mainRoad);

        mainRoadController.AddVehicle(car1);
        car1.Move();

        mainRoadController.AddVehicle(bus1);
        bus1.Move();

        simulation.Update();

        car1.Stop();
        bus1.Stop();

        mainRoadController.RemoveVehicle(car1);
        mainRoadController.RemoveVehicle(bus1);

        simulation.Update();
    }
}