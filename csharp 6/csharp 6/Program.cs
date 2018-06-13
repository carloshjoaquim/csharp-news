using csharp_6.Classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using static System.Math;
using static System.String;

namespace csharp_6
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student("Carlos", "");
            Student student2 = new Student();

            //string interpolation + null - conditional operators
            Console.WriteLine("First Name: {0}" , student?.FirstName);
            Console.WriteLine("Last Name: {0}", student?.LastName);
            Console.WriteLine("FullName : {0}", student?.FullName);

            student.Age = 25;
            student.Friends.Add("José");
            student.Friends.Add("Marina");

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


            Console.ReadKey();
        }
    }
}
