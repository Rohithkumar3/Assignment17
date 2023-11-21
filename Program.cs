using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    internal class Program
    {  
      class BankAccount
      {
        private static int nextAccountNumber = 1;

        // Properties
        public int AccountNumber { get; }
        public string AccountHolderName { get; }
        private decimal Balance { get; set; }

        // Constructors
        public BankAccount(string accountHolderName)
        {
            AccountNumber = nextAccountNumber++;
            AccountHolderName = accountHolderName;
            Balance = 0;
        }

        // Methods
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited ${amount}. New balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Amount must be greater than zero.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn ${amount}. New balance: ${Balance}");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount. Amount must be greater than zero.");
            }
            else
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Current Balance: ${Balance}");
        }
    }
        static void Main(string[] args)
        {
            // Create an instance of the BankAccount class
            BankAccount myAccount =new BankAccount("Ramu");
           // BankAccount myAccount1 = CreateAccount("Rahul");

           myAccount.Deposit( 2000);
            myAccount.Withdraw( 200);
          //  Deposit(myAccount1, 1000);
           // Withdraw(myAccount1, 800);

            // Display account details after each transaction
            DisplayAccountDetails(myAccount);
           // DisplayAccountDetails(myAccount1);
            Console.ReadKey();
        }

        static BankAccount CreateAccount(string accountHolderName)
        {
            return new BankAccount(accountHolderName);
        }
        static void Deposit(BankAccount account, decimal amount)
        {
            account.Deposit(amount);
        }
        static void Withdraw(BankAccount account, decimal amount)
        {
            account.Withdraw(amount);
        }
        static void DisplayAccountDetails(BankAccount account)
        {
            account.DisplayAccountDetails();
        }
         
    }

    }

