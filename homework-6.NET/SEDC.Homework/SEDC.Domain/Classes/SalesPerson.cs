using SEDC.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Domain.Classes
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }
        public SalesPerson(string firstname, string lastname) : base(firstname, lastname, 500, Role.Sales)
        {
            FirstName = firstname;
            LastName = lastname;
        }
        public double AddSuccessRevenue(double number)
        {
            SuccessSaleRevenue = number;
            return SuccessSaleRevenue;
        }
        public override double GetSalary()
        {
            if(SuccessSaleRevenue <= 2000)
            {
                return Salary + 500;
            }
            else if(SuccessSaleRevenue >2000 &&  SuccessSaleRevenue <= 5000)
            {
                return Salary + 1000;
            }
            else 
            {
                return Salary + 1500;
            }
            
        }

    }
}
