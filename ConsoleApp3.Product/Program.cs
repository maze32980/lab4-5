using System.Text;

namespace ConsoleApp3.Product;

public class Program
{
    private static readonly Shop Shop = new();

    private static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        var continueRunning = true;

        while (continueRunning)
        {
            Console.Clear();
            Console.WriteLine("Магазин - Головне меню:");
            Console.WriteLine("1. Додати користувача");
            Console.WriteLine("2. Додати товар");
            Console.WriteLine("3. Пошук товару");
            Console.WriteLine("4. Вихід");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddUser();
                    break;
                case "2":
                    AddProduct();
                    break;
                case "3":
                    SearchProduct();
                    break;
                case "4":
                    continueRunning = false;
                    break;
            }
        }
    }

    private static void AddUser()
    {
        Console.Clear();
        Console.WriteLine("Введіть логін:");
        var login = Console.ReadLine();

        Console.WriteLine("Введіть пароль:");
        var password = Console.ReadLine();

        Shop.AddUser(new User { Login = login, Password = password });
        Console.WriteLine("Користувач доданий!");
        Console.ReadLine();
    }

    private static void AddProduct()
    {
        Console.Clear();
        Console.WriteLine("Введіть назву товару:");
        var name = Console.ReadLine();

        Console.WriteLine("Введіть ціну товару:");
        var price = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть опис товару:");
        var description = Console.ReadLine();

        Console.WriteLine("Введіть категорію товару:");
        var category = Console.ReadLine();

        Shop.AddProdyuct(new Product
            { Name = name, Price = price, Description = description, Category = category });
        Console.WriteLine("Товар доданий!");
        Console.ReadLine();
    }

    private static void SearchProduct()
    {
        Console.Clear();
        Console.WriteLine("Виберіть критерій пошуку:");
        Console.WriteLine("1. За ціною");
        Console.WriteLine("2. За категорією");
        Console.WriteLine("3. За рейтингом");

        var choice = Console.ReadLine();
        List<Product> results = null;

        switch (choice)
        {
            case "1":
                Console.WriteLine("Введіть мінімальну ціну:");
                var minPrice = double.Parse(Console.ReadLine());
                Console.WriteLine("Введіть максимальну ціну:");
                var maxPrice = double.Parse(Console.ReadLine());
                results = Shop.SearchByPrice(minPrice, maxPrice);
                break;
            case "2":
                Console.WriteLine("Введіть категорію:");
                var category = Console.ReadLine();
                results = Shop.SearchByCategory(category);
                break;
            case "3":
                Console.WriteLine("Введіть мінімальний рейтинг:");
                var rating = double.Parse(Console.ReadLine());
                results = Shop.SearchByRating(rating);
                break;
        }

        if (results != null && results.Count > 0)
        {
            Console.WriteLine($"Знайдено {results.Count} товарів:");
            foreach (var product in results) Console.WriteLine($"{product.Name} - {product.Price} грн.");
        }
        else
        {
            Console.WriteLine("Товарів не знайдено.");
        }

        Console.ReadLine();
    }
}