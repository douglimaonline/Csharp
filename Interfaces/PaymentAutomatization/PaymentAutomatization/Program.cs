using System.Globalization;
using PaymentAutomatization.Entities;
using PaymentAutomatization.Services;


namespace PaymentAutomatization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data.");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date(dd/MM/yyyy): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract Value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract contract = new Contract(number, start, contractValue);

            Console.Write("Enter number of installments: ");
            int numOfInstallments = int.Parse(Console.ReadLine());

            Console.Write("Payment Service (Pix/PayPal): ");
            string PaymentService = (Console.ReadLine());

            ContractService contractService = new ContractService();

            contractService.ProcessContract(contract, numOfInstallments, new OnlinePaymentService(), PaymentService);

            Console.WriteLine("Installments:");

            foreach (var installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}