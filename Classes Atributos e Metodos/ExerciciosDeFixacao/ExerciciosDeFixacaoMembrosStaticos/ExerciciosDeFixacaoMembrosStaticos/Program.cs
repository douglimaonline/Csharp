using ExerciciosDeFixacaoMembrosStaticos;

namespace Exercicios {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("-------------------- Exercício 1 --------------------\n");

            Console.Write("Qual a cotação em dólar? ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos Dolares você vai comprar? ");
            double dolares = double.Parse(Console.ReadLine());

            Console.WriteLine(ConversorDeMoeda.Calculo(cotacao, dolares).ToString("F2"));
            
        }

        
    }
}