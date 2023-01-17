using BankSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Classes
{
    public class Atm
    {
        //public static Customer? _customer;
        public static string location { get; } = "Tashkent";
        public static Customer SetCustomer { get; set; }

        public static void Withdraw(double amount)
        {
            if(SetCustomer.Balance <= amount)
            {
                SetCustomer.Balance -= amount;
                Console.WriteLine("You can get your cash money...");
            }
            else
            {
                Console.WriteLine("Enough money to withdraw!");
            }
        }
        public static void Deposit(double amount)
        { 
            if(amount > 0) 
            { 
                SetCustomer.Balance += amount;
                Console.WriteLine("Successful deposited to your account!");
            }
            else
            {
                Console.WriteLine("Unsuccessful deposited!");
            }

        }
        public static double CheckBalance()
        {
            Console.WriteLine($"Balance: {SetCustomer.Balance}");
            Console.ReadKey();
            return SetCustomer.Balance;
        }
    }
}
