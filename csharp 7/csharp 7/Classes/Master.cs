using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.String;

namespace csharp_7.Classes
{
    public class Master : Student
    {
        public string ThesisName { get; }
        
        public string Mentor { get; set; }

        public List<string> Articles { get; set; }

        public Master(string firstName, string lastName, string thesisName)
        {
            //Expressions
            if (IsNullOrWhiteSpace(lastName))
                Console.WriteLine("Parameter cannot be blank: {0}", nameof(lastName));

            FirstName = firstName;
            LastName = lastName;
            ThesisName = ThesisName;
        }

        // Expression-bodied
        public Master(string thesisName) => ThesisName = ThesisName;
    }
}
