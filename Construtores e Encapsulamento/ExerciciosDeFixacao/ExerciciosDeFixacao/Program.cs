using System.Runtime.InteropServices;

namespace ExerciciosDeFixacao {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Entre o número da conta: ");
            int Conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o Titular da conta: ");
            string Titular = Console.ReadLine();

            Console.Write("Haverá Saldo inicial (s/n)? ");
            string SaldoInicial = Console.ReadLine();

            ContaBancaria Conta1 = new ContaBancaria(Conta, Titular);

            if (SaldoInicial == "s") {
                Console.Write("Entre com o valor do depósito inicial: ");
                double DepositoInicial = double.Parse(Console.ReadLine());
                Conta1.Deposito(DepositoInicial);
            }

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(Conta1);

            Console.Write("Entre com o valor do depósito: ");
            double Deposito = double.Parse(Console.ReadLine());
            Conta1.Deposito(Deposito);

            Console.WriteLine("\nDados da conta atualizados:");
            Console.WriteLine(Conta1);

            Console.Write("Entre com o valor do Saque: ");
            double Saque = double.Parse(Console.ReadLine());
            Conta1.Saque(Saque);

            Console.WriteLine("\nDados da conta atualizados:");
            Console.WriteLine(Conta1);

        }
    }
}