namespace ConsoleApp3.Network;

public class Program
{
    public static void Main()
    {
        Computer server = new Server("192.168.0.1", 1000, "Linux", 4);
        Computer workstation = new WorkStation("192.168.0.2", 500, "Windows", "NVIDIA");
        Computer router = new Router("192.168.0.3", 200, "RouterOS", 8);

        var network = new Network();
        network.Connect(server);
        network.Connect(workstation);

        network.TransferData(server, workstation, "Hello, WorkStation!");

        network.Connect(router);
        network.TransferData(router, server, "Hello, Server from Router!");

        network.Disconnect(server);
    }
}