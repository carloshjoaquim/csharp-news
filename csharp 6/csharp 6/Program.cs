using csharp_6.Classes;
using System;
using System.Linq;
using static System.String;
using static System.Math;

namespace csharp_6
{
   public static class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student("Carlos", "Joaquim");
            //string interpolation
            Console.WriteLine("First Name: {0}" , student.FirstName);
            Console.WriteLine("Last Name: {0}", student.LastName);            

            student.Age = 25;
            student.Grades.Add(8);
            student.Grades.Add(6.4);

            //string interpolation
            Console.WriteLine("Age: {0}" , student.Age);
            foreach (double g in student.Grades)
            {
                //string interpolation
                Console.WriteLine("Grade: {0}", g.ToString());
            }

            //using static for String
            if (IsNullOrEmpty(student.Class))
                student.Class = "2nd - A";

            //using static for Math
            var average = student.Grades.Average();
            var squared_average = Pow(average, 2);
            
            //string interpolation
            Console.WriteLine("Average of Grades: {0} - Squared Average: {1}", average, squared_average );


            Console.ReadKey();
        }
    }
}
