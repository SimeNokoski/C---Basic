using SEDC.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Domain.Classes
{
    public class CEO: Employee
    {
        public CEO(string firstName, string lastName, double salary, Role role,List<Employee> employees,int shares) : base(firstName, lastName, salary, role)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Role = role;
            Employees = employees;
            Shares = shares;
        }

        public List<Employee> Employees{ get; set; } = new List<Employee>();
        public int Shares { get; set; }
        private double SharesPrice { get; set; }
        public double AddSharesPrice (double price)
        {
            SharesPrice = price;
            return SharesPrice;
        }
        public void PrintEmployees(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }
        public override double GetSalary()
        {
            return Salary + Shares * SharesPrice;
        }
    }
}
