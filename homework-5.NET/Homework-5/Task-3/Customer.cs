using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Customer
    {
        public string Name { get; set; }
        public long CardNumber { get; set; }
        public int Pin { get; set; }
        public double Balance { get; set; }
        public Customer(string name, long cardNumber, int pin, double balance)
        {
            Name = name;
            CardNumber = cardNumber;
            Pin = pin;
            Balance = balance;
        }
    }
}
