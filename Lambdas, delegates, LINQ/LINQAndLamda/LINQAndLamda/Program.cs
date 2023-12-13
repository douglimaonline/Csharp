using LINQAndLamda.Entities;

namespace LINQAndLamda
{
    internal class Program
    {
        static void Print<T>(string message, ICollection<T> collection)
        {
            Console.WriteLine(message);
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category { Id = 1, Name = "Computers", Tier = 1 };
            Category c3 = new Category { Id = 1, Name = "Eletronics", Tier = 1 };

            List<Product> Products = new List<Product>()
            {
                new Product { Id = 1, Name = "Galaxy", Price = 2400.00, Category = c3},
                new Product { Id = 2, Name = "Batery", Price = 125.00, Category = c3},
                new Product { Id = 3, Name = "Headhpone", Price = 334.00, Category = c3},
                new Product { Id = 4, Name = "Metric Fit", Price = 10.50, Category = c1},
                new Product { Id = 5, Name = "Tablet", Price = 1100.00, Category = c3},
                new Product { Id = 6, Name = "Iphone", Price = 3100.00, Category = c3},
                new Product { Id = 7, Name = "Camera", Price = 700.49, Category = c3},
                new Product { Id = 8, Name = "HP Computer", Price = 4560.00, Category = c2},
                new Product { Id = 9, Name = "Hammer", Price = 77.00, Category = c1},
                new Product { Id = 10, Name = "Printer", Price = 337.45, Category = c3},
                new Product { Id = 11, Name = "Leveler", Price = 23.00, Category = c1},
                new Product { Id = 12, Name = "Macbook", Price = 6742.00, Category = c2},
                new Product { Id = 13, Name = "Saw", Price = 47.23, Category = c1},
                new Product { Id = 14, Name = "TV", Price = 4200.70, Category = c3},
            };

            // tier 1, price < 900
            var result1 = Products.Where(p => p.Price > 900 && p.Category.Tier == 1).ToList();
            Print("tier 1, price < 900", result1);

            // Products of tolls Category
            var result2 = Products.Where(p => p.Category == c1).Select(p => p.Name).ToList();
            Print("Products of tolls Category", result2);
        }
    }
}