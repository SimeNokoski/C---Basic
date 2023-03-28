using SEDC.Domain.Classes;
using SEDC.Domain.Enums;

Employee employee = new Employee("Sime","Nokoski",200,Role.Other);
employee.PrintInfo();

SalesPerson salesPerson = new SalesPerson("Marko", "Markoski");
salesPerson.PrintInfo();
salesPerson.AddSuccessRevenue(4000);
Console.WriteLine("Salary: " + salesPerson.GetSalary());

Manager manager = new Manager("Pavle","Pavleski",Role.Manager,1500);
manager.PrintInfo();
manager.GetSalary();
manager.AddBonus(500);
Console.WriteLine("Manager with bonus: " + manager.GetSalary());

Contractor contractor = new Contractor("Ivan","Ivanoski",2000,Role.Other,8,16,manager);
contractor.PrintInfo();
contractor.CurrentPosition();

Console.WriteLine("");
Console.WriteLine("================");
Console.WriteLine("");

CEO ceoName = new CEO("Ron","Ronsky",1500,Role.Other,new List<Employee> { new Employee("Name1","LastName1",400,Role.Manager),
    new Employee("Name2","LastName2",200,Role.Sales),
    new Employee("Name3","LastName3",700,Role.Other),
    new Employee("Name4","LastName4",900,Role.Manager)
},24);
ceoName.PrintInfo();
List<Employee> company = new List<Employee>() { 
new Contractor("Bob ","Bobert",600,Role.Other,8,12,manager),
new Contractor("Rick ","Rickert",1200,Role.Other,6,17,manager),
new Manager("Mona ","Monalisa",Role.Manager,700),
new Manager("Igor ","Igorsky",Role.Manager,1700),
new SalesPerson("Lea ","Leova")
};
ceoName.PrintEmployees(company);
ceoName.AddSharesPrice(25);
Console.WriteLine(ceoName.GetSalary()); 

 