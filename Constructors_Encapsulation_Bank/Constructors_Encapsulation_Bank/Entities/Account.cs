using System.Globalization;

namespace Constructors_Encapsulation_Bank.Entities
{
    public class Account
    {
        private double _balance;
        public int AccountNumber { get; private set; }
        public string Holder { get; set; }
        
        public Account(int accountNumber, string holder)
        {
            AccountNumber = accountNumber;
            Holder = holder;
        }
        public Account(int accountNumber, string holder, double balance) : this(accountNumber, holder)
        {
            Deposit(balance);
        }

        public override string ToString()
        {
            return "Conta: " + AccountNumber + ", Titular: " + Holder + ", Saldo: $" + _balance.ToString("F2",CultureInfo.InvariantCulture);
        }
        public void Deposit(double value)
        {
            _balance += value;
        }

        public void Withdraw(double value)
        {
            _balance -= value + 5.0;
        }

    }
}
