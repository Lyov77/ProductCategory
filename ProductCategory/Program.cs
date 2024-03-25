using ProductCategory.Data;

namespace ProductCategory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product { Name = "Macbook", Categories = new List<string> { "Tech", "Laptop" } },
                new Product { Name = "Iphone 15", Categories = new List<string> { "Tech", "Phones" } },
                new Product{ Name = "Table", Categories = new List<string>()},
                new Product { Name = "Samsung S14", Categories = new List<string> { "Phones" } },
                new Product { Name = "Book", Categories = new List<string>() },
                new Product { Name = "XBox", Categories = new List<string> { "Console", "Gaming" } },
            };

            // Обработка продуктов и категорий
            ProductCategoryGenerator.GenerateProductCategories(products);
        }
    }
}
