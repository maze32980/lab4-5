namespace ConsoleApp3.Network;

public class Computer
{
    public Computer(string ipAddress, int power, string osType)
    {
        IPAddress = ipAddress;
        Power = power;
        OSType = osType;
    }

    public string IPAddress { get; set; }
    public int Power { get; set; }
    public string OSType { get; set; }
}