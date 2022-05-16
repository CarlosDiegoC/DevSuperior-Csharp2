using System.Globalization;

namespace Composition_Workers.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public Department Department { get; set; }

        public List<HourContract> Contracts = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department) : this()
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += Name + Environment.NewLine;
            retorno += "Level: " + Level + Environment.NewLine;
            retorno += Department + Environment.NewLine;
            return retorno;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public void Income()
        {
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            double income = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if(month < 1 && month > 12)
                {
                    Console.WriteLine("You entered a invalid month.");
                }
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    income += contract.TotalValue();
                }    
            }
            
            Console.WriteLine($"Income for {month}/{year}: ${income.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
