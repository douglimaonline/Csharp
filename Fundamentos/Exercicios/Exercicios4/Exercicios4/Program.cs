using System;

namespace Exercicios {
    internal class Program {
        static void Main(string[] args) {

            // --------------------------- Exercícios 4 ---------------------------

            Console.WriteLine("--------------------------- Exercício 06 ---------------------------");

            Console.Write("Informe um numero inteiro: ");
            int T = int.Parse(Console.ReadLine());

            for (int i = 1; i <= T; i++) {
                if (T % i == 0) {
                    Console.WriteLine(i);
                }
            }

           

            Console.WriteLine("--------------------------- Exercício 07 ---------------------------");

            Console.Write("Informe um numero inteiro: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            }

        }

    }
}