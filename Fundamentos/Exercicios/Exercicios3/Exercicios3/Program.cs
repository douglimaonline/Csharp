using System;

namespace Exercicios {
    internal class Program {
        static void Main(string[] args) {

            // --------------------------- Exercícios 3 ---------------------------

            Console.WriteLine("--------------------------- Exercício 03 ---------------------------");

            // 1.Álcool 2.Gasolina 3.Diesel 4.Fim

            Console.Write("Informe o tipo de Combustível: ");
            int tipo = int.Parse(Console.ReadLine());

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;


            while (tipo != 4) {
                if (tipo == 1) { alcool++; }
                else if (tipo == 2) { gasolina++; }
                else if (tipo == 3) { diesel++; }
                Console.Write("Informe o tipo de Combustível: ");
                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Álcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }

    }
}