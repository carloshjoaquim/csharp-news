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
            Console.WriteLine(student.FirstName + " - First Name");
            Console.WriteLine(student.LastName + " - Last Name");

            student.Age = 25;
            student.Grades.Add(8);
            student.Grades.Add(6.4);

            Console.WriteLine(student.Age + " - Age Name");
            foreach (double g in student.Grades)
            {
                Console.WriteLine("Grade: " + g.ToString());
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
