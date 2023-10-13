namespace ConsoleApp3.Product;

public class User
{
    public string Login { get; set; }
    public string Password { get; set; }
    public List<Order> Orders { get; } = new();
}