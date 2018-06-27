using csharp_7.Classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using static System.Math;
using static System.String;

namespace csharp_7
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student("Carlos", "");
            Student student2 = new Student();
            Master student3 = new Master("Henrique ", "Joaquim", "Big Bang Theory");

            //string interpolation + null - conditional operators
            Console.WriteLine("First Name: {0}" , student?.FirstName);
            Console.WriteLine("Last Name: {0}", student?.LastName);
            Console.WriteLine("FullName : {0}", student?.FullName);

            student.Age = 25;
            student.Friends.Add("José");
            student.Friends.Add("Marina");

            // Index initializers.
            student.MGrades =  new Dictionary<string, double>
            {
                ["English"] = 6.5,
                ["Math"] = 9.9,
                ["Geography"] = 8.5,
                ["History"] = 5.5,
            };

            student3.MGrades = new Dictionary<string, double>
            {
                ["Advanced Math"] = 9.5,
                ["Theory"] = 9.9,
            };

            //string interpolation 
            Console.WriteLine("Age: {0}" , student.Age);
            foreach (KeyValuePair<string, double> g in student.MGrades)
            {
                //string interpolation
                Console.WriteLine("{0} : {1}", g.Key , g.Value);
            }

            //using static for String
            if (IsNullOrEmpty(student.Class))
                student.Class = "2nd - A";

            //using static for Math
            var average = student.MGrades.Values.Average();
            var squared_average = Pow(average, 2);

            //null - conditional operators
            Console.WriteLine("Class: {0}", student?.Class);

            //string interpolation
            Console.WriteLine("Average of Grades: {0} - Squared Average: {1}", average, squared_average );

            //Exception Filters
            try
            {
                var grade = student.Friends.ElementAt(10000);
                Console.WriteLine(grade);
            }
            catch(ArgumentOutOfRangeException ex) when (ex.StackTrace.Contains("OutOfRange"))
            {
                Console.WriteLine("Filtered Exception- Invalid Index for grades list");
            }

            // out variables
            if (student.Passed("History", out double note))
                Console.WriteLine("Passed ! The note is: {0}", note);
            else
            {
                Console.WriteLine("Not Passed in History! The note is: {0}", note);
            }

            // tuple
            (string matter, double vgrade) = student.BestMatter();
            Console.WriteLine("Your best Matter is {0} and your grade is : {1}", matter, vgrade);

            // Discards
            (string worst, _) = student.WorstMatter();
            Console.WriteLine("Your worst Matter is: {0} ", worst);

            // Pattern matching 
            if (student3 is Master master)
            {
                Console.WriteLine($"The {nameof(student3)} is Master !");
                Console.WriteLine($"The Thesis of Master degree is: {master.ThesisName}");
            }
            if (student is Student std)
            {
                Console.WriteLine($"The {nameof(student)} is Student !");
                Console.WriteLine($"Class of student is:  {std.Class}");
            }

            // Ref returns
            student3.InsertArticle("Theory of everthing");
            ref int number = ref student3.NumberArticles();
            Console.WriteLine($"Number of Articles:  {number}");



            Console.ReadKey();
        }
    }
}
