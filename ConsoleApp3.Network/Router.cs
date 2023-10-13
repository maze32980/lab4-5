namespace ConsoleApp3.Network;

public sealed class Router : Computer
{
    public Router(string ipAddress, int power, string osType, int numberOfPorts)
        : base(ipAddress, power, osType)
    {
        NumberOfPorts = numberOfPorts;
    }

    public int NumberOfPorts { get; set; }
}