using csharp_6.Classes;
using System;
using static System.String;

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

            //

            Console.ReadKey();
        }
    }
}
