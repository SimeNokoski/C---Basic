using SEDC.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Domain.Classes
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }
        public Manager(string firstName, string lastName, Role role, double salary) : base(firstName, lastName, salary, role)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
     
        }
        public double AddBonus(double bonus) 
        {
            Bonus = bonus;
            return Bonus;
        }
        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }
}
