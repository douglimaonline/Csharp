namespace Matrizes {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++) {
                Console.Write($"Line {i + 1}: ");
                string[] line = Console.ReadLine().Split(" ");

                for (int j = 0; j < i; j++) {
                    matriz[i, j] = int.Parse(line[j]);
                }
            }
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write($"|{matriz[i, j]}");
                }
            }
        }
    }
}