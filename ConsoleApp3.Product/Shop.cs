namespace ConsoleApp3.Product;

public class Shop : ISearchable
{
    private readonly List<Product> goods = new();
    private readonly List<User> users = new();
    private List<Order> orders = new();

    public List<Product> SearchByPrice(double minPrice, double maxPrice)
    {
        return goods.Where(t => t.Price >= minPrice && t.Price <= maxPrice).ToList();
    }

    public List<Product> SearchByCategory(string category)
    {
        return goods.Where(t => t.Category == category).ToList();
    }

    public List<Product> SearchByRating(double rating)
    {
        return goods.Where(t => t.Rating >= rating).ToList();
    }

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public void AddProdyuct(Product product)
    {
        goods.Add(product);
    }
}