using System.Globalization;
using Inheritance_Employee.Entities;

namespace Inheritance_Employee
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            for(int i = 0; i < numberOfEmployees; i++)
            {
                Console.WriteLine($"Employee #{i+1} data: ");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());
                
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(outsourced == 'n')
                {
                    Employee emp = new Employee(name, hours, valuePerHour);
                    employees.Add(emp);
                }
                else if(outsourced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    OutsourcedEmployee outEmp = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    employees.Add(outEmp);
                }
                else
                {
                    Console.WriteLine("You enter with a invalid option, enter with (y/n)");
                }
            }
            Console.WriteLine("PAYMENTS:");
            employees.ForEach(emp => Console.WriteLine(emp));
        }
    }
}