using BankSystem.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Classes
{
    public static class VerifyCustomer
    {
        public static List<Customer> customers = new()
        {
            new Customer()
            {
                Name = "Abdulatif",
                Address = "Chilanzar",
                Job = "Developer",
                CardNumber = "1234",
                Pin = "2020",
                Balance = 200000
            }
        };
        
        public static Customer? VerifyUser(Customer customer)
        {
            Customer? signInUser = customers.Find(a => a.CardNumber == customer.CardNumber);
            if (signInUser != null)
            {
                if (signInUser.Pin == customer.Pin)
                {
                    return signInUser;
                }
                else 
                { 
                    Console.Write("\apin is incorrect! :( \nPress enter to continue...");  Console.ReadKey(); 
                }
            }
            else { Console.Write("\aNot found like this card number!\nPress enter to continue..."); Console.ReadKey(); }
            
            return null;
        }
    }
}
