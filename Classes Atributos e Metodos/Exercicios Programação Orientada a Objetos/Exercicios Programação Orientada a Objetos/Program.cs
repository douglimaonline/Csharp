using Exercicios_Programação_Orientada_a_Objetos;
using System;

namespace Exercicios {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("--------------------------- Exercício 01 ---------------------------");

            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            pessoa1.name = Console.ReadLine();

            Console.Write("Idade: ");
            pessoa1.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            pessoa2.name = Console.ReadLine();

            Console.Write("Idade: ");
            pessoa2.age = int.Parse(Console.ReadLine());

            if (pessoa1.age > pessoa2.age) {
                Console.WriteLine($"Pessoa mais velha: {pessoa1.name}");
            }
            else {
                Console.WriteLine($"Pessoa mais velha: {pessoa2.name}");
            }

            Console.WriteLine("--------------------------- Exercício 02 ---------------------------");

            Pessoa pessoa3, pessoa4;

            pessoa3 = new Pessoa();
            pessoa4 = new Pessoa();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            pessoa3.name = Console.ReadLine();

            Console.Write("Salário: ");
            pessoa3.wage = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            pessoa4.name = Console.ReadLine();

            Console.Write("Salário: ");
            pessoa4.wage = double.Parse(Console.ReadLine());

            Console.WriteLine($"Salário médio = {((pessoa3.wage + pessoa4.wage) / 2).ToString("F2")}");
        }
    }
}