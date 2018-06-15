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
            Console.WriteLine($"First Name: {student?.FirstName}");
            Console.WriteLine($"Last Name: {student?.LastName}");
            Console.WriteLine($"FullName : {student?.FullName}");

            student.Age = 25;
            student.Friends.Add("José");
            student.Friends.Add("Maria");

            //string interpolation 
            Console.WriteLine($"Age: {student.Age}");
            foreach (KeyValuePair<string, double> g in student.MGrades)
            {
                //string interpolation
                Console.WriteLine($"{g.Key} : {g.Value}");
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
            Console.WriteLine($"Average of Grades: {average:F2} - Squared Average: {squared_average:F2}");

            //Exception Filters
            try
            {
                var grade = student.Friends.ElementAt(10000);
                Console.WriteLine(grade);
            }
            catch (ArgumentOutOfRangeException ex) when (ex.StackTrace.Contains("OutOfRange"))
            {
                Console.WriteLine("Filtered Exception- Invalid Index for grades list");
            }


            Console.ReadKey();
        }
    }
}
