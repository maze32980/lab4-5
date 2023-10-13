namespace ConsoleApp3.Network;

public interface IConnectable
{
    void Connect(Computer comp);
    void Disconnect(Computer comp);
    void TransferData(Computer from, Computer to, string data);
}