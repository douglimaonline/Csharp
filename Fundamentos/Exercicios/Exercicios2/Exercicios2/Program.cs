using System;
using System.Threading.Channels;

namespace Exercicios {
    internal class Program {
        static void Main(string[] args) {

            // --------------------------- Exercícios 2 ---------------------------

            while (true) {

                Console.WriteLine("--------------------------- Exercício 03 ---------------------------");

                Console.Write("Informe o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Informe o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                if (num1 > num2) {
                    if (num1 % num2 == 0) {
                        Console.WriteLine("São Multiplos.");
                    }
                    else {
                        Console.WriteLine("Não são Multiplos");
                    }
                }
                else {
                    if (num2 % num1 == 0) {
                        Console.WriteLine("São Multiplos.");
                    }
                    else {
                        Console.WriteLine("Não são Multiplos");
                    }
                }

            }
        }
    }
}