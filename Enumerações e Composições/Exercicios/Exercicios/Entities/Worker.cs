using Exercicios.Entities.Enums;


namespace Exercicios.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Departament { get; set; }

        public List<HourContract> Contracts = new List<HourContract>();

        public Worker(string name, WorkerLevel level, double baseSalary, Department departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }
        public void AddContract (HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract (HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int Year, int Month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == Year && contract.Date.Month == Month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
