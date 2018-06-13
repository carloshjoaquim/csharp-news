using System;
using System.Collections.Generic;
using static System.String;

namespace csharp_6.Classes
{
    public class Student
    {
        //Read-only properties
        public string FirstName { get; }
        public string LastName { get; }

        //Common properties
        public int Age { get; set;}
        public string Class { get; set; }

        //Auto-Property Initializers
        public ICollection<string> Friends { get; } = new List<string>();

        //Expression-bodied 
        public string FullName => $"{FirstName} {LastName}";

        //Index Initializers
        public Dictionary<string, double> MGrades = new Dictionary<string, double>
        {
            ["English"] = 6.5,
            ["Math"] = 9.9,
            ["Geography"] = 8.5,
            ["History"] = 8,
        };

        public Student(string firstName, string lastName)
        {
            //Expressions
            if (IsNullOrWhiteSpace(lastName))
                Console.WriteLine("Parameter cannot be blank: {0}", nameof(lastName));

            FirstName = firstName;
            LastName = lastName;
        }

        public Student() { }

    }
}
