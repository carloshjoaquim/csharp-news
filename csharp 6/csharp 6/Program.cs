using csharp_6.Classes;
using System;
using System.Globalization;
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
            Student student = new Student("Carlos", "Joaquim");
            Student student2 = new Student();

            //string interpolation + null - conditional operators
            Console.WriteLine("First Name: {0}" , student?.FirstName);
            Console.WriteLine("Last Name: {0}", student?.LastName);
            Console.WriteLine("FullName : {0}", student?.FullName);

            //student.Age = 25;
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

            //null - conditional operators
            Console.WriteLine("Class: {0}", student?.Class);

            //string interpolation
            Console.WriteLine("Average of Grades: {0} - Squared Average: {1}", average, squared_average );

            //Exception Filters
            try
            {
                var grade = student.Grades.ElementAt(10000);
                Console.WriteLine(grade);
            }
            catch(ArgumentOutOfRangeException ex) when (ex.StackTrace.Contains("OutOfRange"))
            {
                Console.WriteLine("Exceção filtrada - Índice inválido");
            }


            Console.ReadKey();
        }
    }
}
