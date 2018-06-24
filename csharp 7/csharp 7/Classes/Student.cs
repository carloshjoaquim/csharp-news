using System;
using System.Collections.Generic;
using System.Linq;
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
            ["History"] = 5.5,
        };

        public Student(string firstName, string lastName)
        {
            //Expressions
            if (IsNullOrWhiteSpace(lastName))
                Console.WriteLine("Parameter cannot be blank: {0}", nameof(lastName));

            FirstName = firstName;
            LastName = lastName;
        }

        public bool Passed(string grade, out double average)
        {
            average = MGrades.Where(x => x.Key.Equals(grade)).FirstOrDefault().Value;
            // Returns true if grade is bigger or equal 6
            return MGrades.Where(x => x.Key.Equals(grade)).FirstOrDefault().Value >= 6;
        }

        public (string matter, double note) BestMatter()
        {
            var result = MGrades.OrderByDescending(x => x.Value).FirstOrDefault();
            return (result.Key, result.Value);
        }

        public (string matter, double note) WorstMatter()
        {
            var result = MGrades.OrderByDescending(x => x.Value).LastOrDefault();
            return (result.Key, result.Value);
        }

        public Student() { }

    }
}
