using SEDC.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Domain.Classes
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        protected double Salary { get; set; }
        public Role Role { get; set; }

        public Employee(string firstName, string lastName, double salary, Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} {Salary} = {Role} ");
        }
        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
