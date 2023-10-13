namespace ConsoleApp3.Network;

public sealed class Server : Computer
{
    public Server(string ipAddress, int power, string osType, int numberOfHardDrives)
        : base(ipAddress, power, osType)
    {
        NumberOfHardDrives = numberOfHardDrives;
    }

    public int NumberOfHardDrives { get; set; }
}