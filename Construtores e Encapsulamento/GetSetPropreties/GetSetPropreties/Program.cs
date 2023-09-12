namespace GetSetPropreties {
    internal class Program {
        static void Main(string[] args) {
            
            Produto p = new Produto("TV", 1000, 3);

           p.Nome = "TV-4K";

            Console.WriteLine(p.Nome);

        }
    }
}