using BankSystem.Classes;
using BankSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.ConsoleApp
{
    public class ConsoleUser
    {

        private bool isActive = true, isTrue = true;
        private int _choice;
        private string _cardNumber, _pin;
        private double _amount;

        List<Customer> managedBy = new();

        public void SystemUseInConsole()
        {
            
            Console.WriteLine("---------------Welcome to our Bank---------------\n");
            while (isActive)
            {
                Console.Clear();
                Console.WriteLine("1.Sign in\n2.Sign up\n3.Exit\nChoose option bro :) ");
                _choice = Convert.ToInt16(Console.ReadLine());
                switch (_choice)
                {
                    case 1:
                        {
                            Console.Write("enter your card number: ");
                            _cardNumber = Console.ReadLine();
                            Console.Write("enter pin: ");
                            _pin = Console.ReadLine();

                            var user = new Customer()
                            {
                                CardNumber = _cardNumber,
                                Pin = _pin
                            };

                            Atm.SetCustomer = VerifyCustomer.VerifyUser(user);
                            if (Atm.SetCustomer != null)
                            {
                                managedBy.Add(user);
                                while (isTrue)
                                {
                                    Console.Clear();
                                    Console.WriteLine("1.Withdraw\n2.Deposit\n3.Balance\n4.Back\nChoose option bro :)");
                                    _choice = Convert.ToInt32(Console.ReadLine());

                                    switch(_choice)
                                    {
                                        case 1:
                                            {
                                                Console.Write("enter amount of withdraw: ");
                                                _amount = Convert.ToDouble(Console.ReadLine());
                                                Atm.Withdraw(_amount);
                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadKey();
                                            }break;
                                        case 2:
                                            {
                                                Console.Write("enter amount of deposit: ");
                                                _amount = Convert.ToDouble(Console.ReadLine());
                                                Atm.Deposit(_amount);
                                                Console.WriteLine("Press any key to continue...");
                                                Console.ReadKey();
                                            }
                                            break;
                                        case 3:
                                            {
                                                Console.WriteLine($"Your current balance: {Atm.CheckBalance()}\nPress any key to continue...");
                                                Console.Clear();
                                            }
                                            break;
                                        case 4: { isTrue = false; } break;
                                        default: Console.Clear(); break;
                                    }
                                }
                            }
                        } break;

                    case 2:
                        {
                            Console.Write("name: ");
                            string name = Console.ReadLine();
                            Console.Write("adress: ");
                            string address = Console.ReadLine();
                            Console.Write("job: ");
                            string job = Console.ReadLine();
                            Console.Write("card number: ");
                            string card = Console.ReadLine();
                            Console.Write("pin: ");
                            string pin = Console.ReadLine();

                            var SignUpUser = new Customer()
                            {
                                Name = name,
                                Address = address,
                                Job = job,
                                CardNumber = card,
                                Pin = pin
                            };
                            VerifyCustomer.customers.Add(SignUpUser);
                            Console.WriteLine("you are successfull registered to our bank system, go bro :)");
                        }break;
                    case 3:
                        {
                            isActive = false;
                        }break;
                    default:
                        {
                            Console.Clear();
                        }break;
                }
            }
        }
    }
}
