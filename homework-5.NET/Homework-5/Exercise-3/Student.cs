using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Student
    {
        public string Name { get; set; }    
        public string Academy { get; set; } 
        public string Group { get; set; }   

        public void Info()
        {
            Console.WriteLine($"Name: {Name} Academy: {Academy} Group: {Group}");
        }
    }
}
