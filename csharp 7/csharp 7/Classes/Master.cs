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

        public List<string> Articles { get; set; } = new List<string>();

        private int PublishedArticles = 0;

        public Master(string firstName, string lastName, string thesisName)
        {
            //Expressions
            if (IsNullOrWhiteSpace(lastName))
                Console.WriteLine("Parameter cannot be blank: {0}", nameof(lastName));

            // throw
           ThesisName = IsNullOrEmpty(thesisName) ? throw new ArgumentNullException(paramName: nameof(thesisName),
                message: "The thesis Name is required.") : thesisName;

            FirstName = firstName;
            LastName = lastName;
        }

        // Expression-bodied
        public Master(string thesisName) => ThesisName = ThesisName;

        public void InsertArticle(string name)
        {
            PublishedArticles += 1;
            Articles.Add(name);
        }

        public ref int NumberArticles()
        {
            return ref PublishedArticles;
        }
    }
}
