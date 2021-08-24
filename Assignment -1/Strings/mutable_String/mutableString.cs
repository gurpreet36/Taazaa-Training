using System;
using System.Text;

namespace mutable_String
{
    class mutableString
    {
        static void Main(string[] args)
        {
            StringBuilder a =new StringBuilder("Hello World!");
            Console.WriteLine("value of a :-"+a);
            a.Replace("Hello World!","Gurpreet Singh");
            Console.WriteLine("New value of a :-"+a); // here it replace Hello World! to Gurpreet Singh in same memory location
        }
    }
}
