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
            Console.WriteLine();
            Console.Write("\nInteger number: ");
            int N = int.Parse(Console.ReadLine());

            int TotalTimes = 0;
            for (int i = 0; i < Matriz.GetLength(0); i++) {
                for (int j = 0; j < Matriz.GetLength(1); j++) {
                    if (Matriz[i, j] == N) {
                        TotalTimes++;
                    };
                }
            }
            Console.WriteLine($"The Number '{N}' shows up {TotalTimes} times. ");
            Console.WriteLine();

            for (int i = 0; i < Matriz.GetLength(0); i++) {
                for (int j = 0; j < Matriz.GetLength(1); j++) {
                    if (Matriz[i,j] == N) {
                        Console.WriteLine($"Position: ({i}, {j})");
                        if (j > 0) { Console.WriteLine($"Left: {Matriz[i, j-1]}"); };
                        if (j < Matriz.GetLength(1)-1) { Console.WriteLine($"Right: {Matriz[i,j+1]}"); }
                        
                        if (i > 0) { Console.WriteLine($"Up: {Matriz[i-1, j]}"); }
                        if (i < Matriz.GetLength(0)-1) { Console.WriteLine($"Down: {Matriz[i+1, j]}"); }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}