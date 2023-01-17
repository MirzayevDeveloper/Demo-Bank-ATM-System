using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Interfaces
{
    public interface ICustomer
    {
        string Name { get; set; }
        string Address { get; set; }
        string Job { get; set; }
        string CardNumber { get; set; }
        string Pin { get; set; }
        double Balance { get; set; }
        
    }
}
