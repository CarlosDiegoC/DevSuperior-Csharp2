using Constructors_Encapsulation_Bank.Entities;
using System.Globalization;

namespace Constructor_Encapsulation_Bank
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número da conta: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string holder = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (s/n)");
            char initialDeposit = char.Parse(Console.ReadLine());

            Account account = new Account(accountNumber, holder);

            if(initialDeposit == 's' || initialDeposit == 'S')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double depositValue = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                account = new Account(accountNumber, holder, depositValue);
            }
            else
            {
                account = new Account(accountNumber, holder);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double newDepositValue = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            account.Deposit(newDepositValue);
            Console.WriteLine(account);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double newWithdrawValue = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            account.Withdraw(newWithdrawValue);
            Console.WriteLine(account);
        }
    }
}