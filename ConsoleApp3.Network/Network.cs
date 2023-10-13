namespace ConsoleApp3.Network;

public class Network : IConnectable
{
    private readonly List<Computer> _computersInNetwork = new();

    public void Connect(Computer comp)
    {
        _computersInNetwork.Add(comp);
        Console.WriteLine($"Computer with IP address {comp.IPAddress} connected to the network.");
    }

    public void Disconnect(Computer comp)
    {
        _computersInNetwork.Remove(comp);
        Console.WriteLine($"Computer with IP address {comp.IPAddress} disconnected from the network.");
    }

    public void TransferData(Computer from, Computer to, string data)
    {
        if (_computersInNetwork.Contains(from) && _computersInNetwork.Contains(to))
            Console.WriteLine($"Data from {from.IPAddress} to {to.IPAddress}: {data}");
        else
            Console.WriteLine("One or both computers are not in the network.");
    }
}