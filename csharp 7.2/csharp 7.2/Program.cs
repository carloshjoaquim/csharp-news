using System;

namespace csharp_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Non-trailing named arguments
            printValues(name: "Carlos", lastName: "Joaquim", 26);
            printValues(lastName: "Example", name: "Person", age: 30, code: "Code ABC");

            VehicleTest vehicleTest = new VehicleTest
                {
                    Code = "ABC",
                    Color = "Black",
                    CV = 950
                };

            vehicleTest.ShowProperties();

            Console.ReadKey();
        }


        public static void printValues(string name, string lastName, int age = 18, string code = "Default Code")
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"LastName: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Code: {code}");
            Console.WriteLine("==");
        }
    }

    public class VehicleTest : Vehicle
    {
        new public void ShowProperties()
        {
            Console.WriteLine("Vehicle Properties: ");
            base.ShowProperties();
        }
    }
}
