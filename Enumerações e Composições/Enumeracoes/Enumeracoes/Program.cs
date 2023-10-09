namespace Enumeracoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> MyList = new List<string> {"doug", "Juca", "Igo", "Thais", "Carol"};

            Console.Write("MyList = ");
            foreach (var item in MyList)
            {
                Console.Write($"{item}, ");
            }
        }
    }
}