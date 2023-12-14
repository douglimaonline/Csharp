namespace Exercicio
{
    internal class Program
    {
        class Products
        {
            public string Name { get; set; }
            public double Value { get; set; }

            public override string ToString()
            {
                return $"{Name} - {Value.ToString("F2")}";
            }
        }
        static void Main(string[] args)
        {
            List<Products> products = new List<Products> ();

            string FilePath = @"G:\My Drive\Estudos\Csharp\Lambdas, delegates, LINQ\Exercicio\Exercicio\Products.csv";

            using (FileStream fs = new FileStream(FilePath, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        var splitline = line.Split(';');
                        products.Add (new Products { Name = splitline[0], Value = double.Parse(splitline[1])});
                    }
                }
            }
            Console.WriteLine("All Products:");
            foreach (var p in products)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            var average = products.Average(a => a.Value);
            
            Console.Write("Average Price: ");
            Console.WriteLine($"{average.ToString("F2")}\n");
            
            var list = products.Where(p => p.Value < average).OrderBy(p => p.Value);
            Console.WriteLine("Products with price lower then average:");
            foreach (Products p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}