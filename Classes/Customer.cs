using BankSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Classes
{
    public class Customer : ICustomer
    {
        private string _name, _address, _job, _cardNumber, _pin;
        private double _balance;
        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string Job
        {
            get { return _job; }
            set { _job = value; }
        }
        public string CardNumber
        {
            get { return _cardNumber; }
            set { _cardNumber = value; }
        }
        public string Pin
        {
            get { return _pin; }
            set { _pin = value; }
        }

    }
}
