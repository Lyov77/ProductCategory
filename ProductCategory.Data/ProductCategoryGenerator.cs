namespace ProductCategory.Data
{
    public static class ProductCategoryGenerator
    {
        public static void GenerateProductCategories(List<Product> products)
        {
            // Продукты с категориями
            var productsWithCategories = products
                .SelectMany(product => product.Categories.Select(category => new { ProductName = product.Name, CategoryName = category }))
                .ToList();

            // Продукты, у которых нет категорий
            var productsWithoutCategories = products
                .Where(product => !product.Categories.Any())
                .Select(product => product.Name)
                .ToList();

            // Вывод результатов
            Console.WriteLine("Пары \"Имя продукта - Имя категории\":");
            foreach (var pair in productsWithCategories)
            {
                Console.WriteLine($"{pair.ProductName} - {pair.CategoryName}");
            }

            Console.WriteLine("\nПродукты без категорий:");
            foreach (var productName in productsWithoutCategories)
            {
                Console.WriteLine(productName);
            }
        }
    }
}
