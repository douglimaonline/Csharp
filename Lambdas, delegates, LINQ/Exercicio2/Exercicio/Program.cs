namespace Exercicio2
{
    internal class Program
    {
        class Employee
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public double Salary { get; set; }
        }
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();

            string FilePath = @"G:\My Drive\Estudos\Csharp\Lambdas, delegates, LINQ\Exercicio2\Exercicio\Employee.csv";

            using (FileStream fs = new FileStream(FilePath, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        var splitline = line.Split(';');
                        Employees.Add(new Employee { Name = splitline[0], Email = splitline[1], Salary = double.Parse(splitline[2]) });
                    }
                }
            }
            Console.WriteLine("Employees:");
            foreach (Employee emp in Employees)
            {
                Console.WriteLine(emp.Name);
            }
            Console.WriteLine();

            Console.Write("Enter the Salary: ");
            var salary = double.Parse(Console.ReadLine());
            Console.WriteLine($"\nEmail of people whose salary is more than {salary}:");
            var emps = Employees.Where(e => e.Salary > salary).OrderBy(p => p.Name).ToList();
            foreach (Employee emp in emps)
            {
                Console.WriteLine(emp.Email);
            }
            Console.WriteLine();
            Console.Write("Sum of salary of people whose name starts with 'M':");
            var sumSalary = Employees.Where(e => e.Name[0].ToString() == "M").Sum(e => e.Salary);
            Console.WriteLine(sumSalary);
        }
    }
}