
using Exercise_3;

Student[] arrStudents = new Student[5] {
  new Student { Name = "Sime",Academy = "SEDC",Group = "G2"},
  new Student { Name = "Marko", Academy = "SEDC", Group = "G4" },
  new Student { Name = "Dajo", Academy = "SEDC", Group = "G1" },
  new Student { Name = "Petar", Academy = "SEDC", Group = "G6" },
  new Student { Name = "Aco", Academy = "SEDC", Group = "G5" }
};

Console.WriteLine("Enter name");
string inputName = Console.ReadLine();  
bool found = false;
foreach (Student student in arrStudents)
{
    if(inputName.ToUpper() == student.Name.ToUpper())
    {
        found = true;
        student.Info();
        break;
    }
}

if (!found)
{
    Console.WriteLine("Student not found");
}

