using System;

namespace csharp_7._2
{
    public class Vehicle
    {
        public string Color { get; set; }
        public int CV { get; set; }
        public string Code { get; set; }


        private protected void ShowProperties()
        {
            Console.WriteLine($"Type: {Color}-{CV}-{Code}");
        }
    }
}
