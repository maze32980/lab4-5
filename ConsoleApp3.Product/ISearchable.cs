namespace ConsoleApp3.Product;

public interface ISearchable
{
    List<Product> SearchByPrice(double minPrice, double maxPrice);
    List<Product> SearchByCategory(string category);
    List<Product> SearchByRating(double rating);
}