
// Alterações que achei interessante após as correções:
using System.Globalization;

namespace ExerciciosDeFixacao {
    internal class Program {
        static void Main(string[] args) {

            ContaBancaria Conta;

            Console.Write("Entre o número da conta: ");
            int IdConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o Titular da conta: ");
            string Titular = Console.ReadLine();


            Console.Write("Haverá Saldo inicial (s/n)? ");
            string resp = Console.ReadLine();

            if (resp == "s" || resp == "S") {
                Console.Write("Entre com o valor do depósito inicial: ");
                double DepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Conta = new ContaBancaria(IdConta, Titular, DepositoInicial);
            } else {
                Conta = new ContaBancaria(IdConta, Titular);
            }

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(Conta);

            Console.Write("Entre com o valor do depósito: ");
            double Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Conta.Deposito(Valor);

            Console.WriteLine("\nDados da conta atualizados:");
            Console.WriteLine(Conta);

            Console.Write("Entre com o valor do Saque: ");
            Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Conta.Saque(Valor);

            Console.WriteLine("\nDados da conta atualizados:");
            Console.WriteLine(Conta);

        }
    }
}