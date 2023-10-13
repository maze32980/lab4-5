namespace ConsoleApp3.Network;

public sealed class WorkStation : Computer
{
    public WorkStation(string ipAddress, int power, string osType, string videoCardType)
        : base(ipAddress, power, osType)
    {
        VideoCardType = videoCardType;
    }

    public string VideoCardType { get; set; }
}