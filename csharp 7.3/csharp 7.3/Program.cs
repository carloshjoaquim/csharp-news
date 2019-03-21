using System;

namespace csharp_7._3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ref local variables may be reassigned.
            var myStruct = new MyStruct();
            var myAnotherStruct = new MyStruct();

            ref MyStruct refLocal = ref myStruct;
            refLocal = ref myAnotherStruct;
                       
        }

        private unsafe void Foo()
        {
            // stackalloc arrays support initializers
            int* intArray = stackalloc int[3] { 1, 2, 3 };            
        }
    }

    public struct MyStruct
    {
        public string NameStruct { get; set; }
        public string CodeStruct { get; set; }
    }   
}

