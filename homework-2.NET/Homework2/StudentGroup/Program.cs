// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] studentsG1 = { "Petar","Marko","Danilo","Aco","Filip"};
string[] studentsG2 = { "Sime", "Goce", "Gjoce", "Mitre", "Petko" };

Console.WriteLine("Enter student group: 1 or 2");
int studentGroup = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The Students in G{studentGroup} are:");
if(studentGroup == 1)
{
    foreach(string student in studentsG1)
    {
        Console.WriteLine(student);
    }
}
else if(studentGroup == 2)
{
    foreach (string student in studentsG2)
    {
        Console.WriteLine(student);
    }
}
else
{
    Console.WriteLine("Enter 1 or 2");
}