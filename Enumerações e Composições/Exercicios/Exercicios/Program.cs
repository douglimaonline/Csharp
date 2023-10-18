using Exercicios.Entities.Enums;
using System.Diagnostics.Contracts;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament's name: ");
            string DptoName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string Name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel Level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double BaseSalary = double.Parse(Console.ReadLine());
            Console.Write("How many contracts to this worker? ");
            int NumOfContracts = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < NumOfContracts; i++)
            {
                Console.WriteLine($"Enter #{i + 1} contract data:");
                Console.Write("Date (DD/MM/YYY): ");
                DateTime Date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double ValuePHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hour): ");
                int Hours = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");

            }
        }
    }
}