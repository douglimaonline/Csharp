namespace Febonacci {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Informe um numero inteiro: ");
            int n = int.Parse(Console.ReadLine());
            List<int> febonacciList = new List<int>();
            febonacciList.Add(0);
            febonacciList.Add(1);

            for (int i = 2; i < n; i++) {
                febonacciList.Add(febonacciList[(febonacciList.Count-2)] + febonacciList[(febonacciList.Count- 1)]);
            }
            Console.WriteLine($"Modelo Febonacci com {n} itens.");
            foreach (var item in febonacciList) {
                Console.WriteLine(item);
            }
            {
                
            }
        } 
    }
}