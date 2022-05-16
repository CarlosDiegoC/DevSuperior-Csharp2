using Lists_Employees;
using System.Globalization;
namespace List_Employees
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            
            List<Employee> employees = new List<Employee>();
            
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #" + (i+1));
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(new Employee(id, name, salary));
            }
            
            Console.Write("Enter the employee id that will have salary increase: ");
            int idEmployee = int.Parse(Console.ReadLine());
                       
            if (employees.Exists(x => x.Id == idEmployee))
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Find(x => x.Id == idEmployee).IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This employee id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            employees.ForEach(x => Console.WriteLine(x));
        }
    }
}
