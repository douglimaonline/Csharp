using System.Collections.Generic;
using System.Globalization;
namespace ExerciciosDeFixacaoListas {
    internal class Program {
        static void Main(string[] args) {
            List<Employee> Employees = new List<Employee>();

            Console.Write("How many employers will be registrered? ");
            int NumOfEmps = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumOfEmps; i++) {
                Console.WriteLine($"\nEmployee #{i + 1}");

                Console.Write("Id: ");
                int Id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string Name = Console.ReadLine();

                Console.Write("Salary: ");
                double Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employees.Add(new Employee(Id, Name, Salary));
            }
            Console.Write("\nEnter the employee Id that will have a salary increase: ");
            int EmployeeIdIncrease = int.Parse(Console.ReadLine());

            if (Employees.Find(x => x.Id == EmployeeIdIncrease) == null) {
                Console.WriteLine("This id does not exist!");
            }
            else {

                Console.Write("Enter the percentage: ");
                double Percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employees.Find(x => x.Id == EmployeeIdIncrease).IncreaseSalary(Percentage);

                Console.WriteLine("\nUpdated list of employees:");
                foreach (var item in Employees) {
                    Console.WriteLine(item);
                }
            }


        }
    }
}