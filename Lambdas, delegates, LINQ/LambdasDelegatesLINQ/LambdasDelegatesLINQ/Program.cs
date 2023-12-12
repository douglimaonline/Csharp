using System;

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
                new Product { Name = "TV", Price = 400.00 },
                new Product { Name = "Table", Price = 150.00 },
                new Product { Name = "Windown", Price = 160.00 },
                new Product { Name = "Computer", Price = 340.00 },
                new Product { Name = "Smathfone", Price = 560.00 }
            };

            List<Product> Spansive = Products.FindAll(p => p.Price > 200).ToList();

            foreach (Product p in Spansive)
            {
                Console.WriteLine(p);
            }
        }
    }
}