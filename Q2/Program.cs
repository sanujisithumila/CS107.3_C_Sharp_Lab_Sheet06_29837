using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    public abstract class BankAccount
    {    

        public abstract void Deposit(double amount);

        public abstract void Withdraw(double amount);

        public double balance;
        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Current Balance: {balance}");
        }

    }

    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(double initialBalance) : base(initialBalance) { }
        public override void Deposit(double amount)
        {
            balance += amount;
        }

        public override void Withdraw(double amount)
        {
            if (balance - amount >= 0) {
                balance = amount;
            }

            else
            {
                Console.WriteLine("Insufficient Funds");
            }
           
        }

    }

    public class CurrentAccount : BankAccount
    {
        public CurrentAccount(double initialBalance) : base(initialBalance) { }
        //Constructor for the SavingsAccount class and base class constructor

        public override void Deposit(double amount)
        {
            balance += amount;
        }

        public override void Withdraw(double amount)
        {
            balance -= amount;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savingsAccount = new SavingsAccount(1000);
            CurrentAccount currentAccount = new CurrentAccount(2000);

            Console.WriteLine("Select transaction type: ");
            Console.WriteLine("1. Deposit\t\t  2. Withdraw\n");
            int transactionType = int.Parse(Console.ReadLine());

            Console.WriteLine("Select account type: ");
            Console.WriteLine("1. Savings\t\t  2. Current\n");
            int accountType = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter Amount: ");
            double amount = double.Parse(Console.ReadLine());

            if (accountType == 1)
            {
                if(transactionType == 1)
                {
                    savingsAccount.Deposit(amount); 
                }
                else
                {
                    savingsAccount.Withdraw(amount);
                }
                savingsAccount.DisplayBalance();
            }
            else if (accountType == 2)
            {
                if(transactionType == 1)
                {
                    currentAccount.Deposit(amount);
                }
                else
                {
                    currentAccount.Withdraw(amount);
                }
                currentAccount.DisplayBalance();
            }
            else
            {
                Console.WriteLine("Choose account type or transaction type");
            }

            Console.ReadLine();
        }
    }
}
