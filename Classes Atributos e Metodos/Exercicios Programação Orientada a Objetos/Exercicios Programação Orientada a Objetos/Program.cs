using Exercicios_Programação_Orientada_a_Objetos;
using System;

namespace Exercicios {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("--------------------------- Exercício 01 ---------------------------");

            Person pessoa1, pessoa2, calculo;

            pessoa1 = new Person();
            pessoa2 = new Person();
            calculo = new Person();

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

            Console.WriteLine(calculo.Older(pessoa1, pessoa2));
            

            Console.WriteLine("--------------------------- Exercício 02 ---------------------------");

            Person pessoa3, pessoa4;

            pessoa3 = new Person();
            pessoa4 = new Person();

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