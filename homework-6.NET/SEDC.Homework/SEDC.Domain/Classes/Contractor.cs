using SEDC.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Domain.Classes
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }
        public Contractor(string firstName, string lastName, double salary, Role role,double workhours,int payperhour,Manager responisble) : base(firstName, lastName, salary, role)
        {
            WorkHours = workhours;
            PayPerHour = payperhour;
            Responsible = responisble;
        }
        public override double GetSalary()
        {
           Salary = WorkHours * PayPerHour;
            return Salary;
        }
        public void CurrentPosition()
        {
            Console.WriteLine($"Responsible for {FirstName} {LastName}, the department of the manager {Responsible.FirstName} {Responsible.LastName}"); 
        }
    }
}
