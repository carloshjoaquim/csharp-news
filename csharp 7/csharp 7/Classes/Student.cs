using System;
using System.Collections.Generic;
using System.Linq;
using static System.String;

namespace csharp_7.Classes
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Common properties
        public int Age { get; set;}
        public string Class { get; set; }

        //Auto-Property Initializers
        public ICollection<string> Friends { get; } = new List<string>();

        //Expression-bodied 
        public string FullName => $"{FirstName} {LastName}";

        //Index Initializers
        public Dictionary<string, double> MGrades;

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
