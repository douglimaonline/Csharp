namespace ExerciciosDeFixacaoMatrizes {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Lines: ");
            int LineNum = int.Parse(Console.ReadLine());
            Console.Write("Columns: ");
            int ColNum = int.Parse(Console.ReadLine());
            int[,] Matriz = new int[LineNum, ColNum];

            for (int i = 0; i < LineNum; i++) {
                Console.Write($"Line {i + 1} (separate by space): ");
                string[] line = Console.ReadLine().Split(' ');

                for (int j = 0; j < ColNum; j++) {
                    Matriz[i,j] = int.Parse(line[j]);
                }
            }
            Console.WriteLine("\nMatriz:");
            for (int i = 0;i < Matriz.GetLength(0); i++) {
                if (i > 0) { Console.WriteLine(); };
                for (int j = 0;j < Matriz.GetLength(1); j++) {
                    Console.Write($"{Matriz[i,j]} ");
                }
            }
        }
    }
}