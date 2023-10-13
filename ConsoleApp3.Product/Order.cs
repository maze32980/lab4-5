namespace ConsoleApp3.Product;

public class Order
{
    public Product Product { get; set; }
    public int Count { get; set; }
    public double Total => Product.Price * Count;
    public string Status { get; set; }
}