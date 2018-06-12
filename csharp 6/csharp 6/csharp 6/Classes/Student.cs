using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_6.Classes
{
   public class Student
    {
        //Read-only properties
        public string FirstName { get; }
        public string LastName { get; }

        //Common properties
        public int Age { get; set;}

        //Auto-Property Initializers
        public ICollection<double> Grades { get; } = new List<double>();

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

    }
}
