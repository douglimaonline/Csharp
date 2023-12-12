using System;
using System.Linq;

namespace LambdasDelegatesLINQ
{

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Price}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> Products = new List<Product>
            {
                new Product { Name = "TV", Price = 405.00 },
                new Product { Name = "Table", Price = 150.00 },
                new Product { Name = "Windown", Price = 163.00 },
                new Product { Name = "Computer", Price = 342.00 },
                new Product { Name = "Smathfone", Price = 561.00 }
            };

            // List<Product> Spansive = Products.FindAll(p => p.Price > 200).ToList();
            var result = Products.Where(s => s.Price % 2 == 0).Select(s => s.Price * 10);

            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        }
    }
}