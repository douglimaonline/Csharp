namespace Matrizes {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++) {
                Console.Write($"Line {i + 1}: ");
                string[] line = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) {
                    matriz[i, j] = int.Parse(line[j]);
                }
            }
            Console.WriteLine($"\nMinha Matriz é:");
            for (int i = 0;i < matriz.GetLength(0); i++) {
                if (i > 0) { Console.WriteLine(); };
                for (int j = 0;j < matriz.GetLength(1); j++) {
                    Console.Write($"{matriz[i,j]} ");
                }
            }
            Console.WriteLine();
        }
    }
}