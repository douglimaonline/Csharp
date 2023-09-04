using System;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // // --------------------------- Exercício de fixação ---------------------------

            // Console.Write("Entre com seu nome completo: ");
            // string name = Console.ReadLine();

            // Console.Write("Quantos quartos tem na sua casa: ");
            // int rooms = int.Parse(Console.ReadLine());

            // Console.Write("Entre com o preço do produto: ");
            // double price = double.Parse(Console.ReadLine());

            // Console.Write("Entre seu último nome, idade e altura (mesma linha): ");
            // string[] text = Console.ReadLine().Split(" ");

            // Console.WriteLine(name);
            // Console.WriteLine(rooms);
            // Console.WriteLine(price);
            // Console.WriteLine(text[0]);
            // Console.WriteLine(text[1]);
            // Console.WriteLine(text[2]);

            // --------------------------- Estrutura Sequencial Exercício 06 ---------------------------

            double pi = 3.14159;

            Console.Write("Informa o valor para A: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Informa o valor para B: ");
            double B = double.Parse(Console.ReadLine());
            Console.Write("Informa o valor para C: ");
            double C = double.Parse(Console.ReadLine());

            double areaDoTriangulo = (A*C) / 2;
            double AreaDoCirculo = pi * (Math.Pow(C, 2));
            double areaDoTrapezio = (A+B) * (C/2);
            double areaDoQuadrado = Math.Pow(B, 2);
            double areasDoRetangulo = A*B;
                
            Console.WriteLine(areaDoTriangulo.ToString("F3"));
            Console.WriteLine(AreaDoCirculo.ToString("F3"));
            Console.WriteLine(areaDoTrapezio.ToString("F3"));
            Console.WriteLine(areaDoQuadrado.ToString("F3"));
            Console.WriteLine(areasDoRetangulo.ToString("F3"));


        }
    }
}