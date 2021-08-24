using System;

namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //For Boxing Process
            String name="Gurpreet Singh";//(value type)
            // variable name of string type which is stored in stack memory.
            object box=name;//(reference type)
            //here object box convert value type to object type hence boxing is done
            name="Gurpreet";// new value for name variable
            Console.WriteLine("value of name before unboxing :-"+name);
           
            // for unboxing process
            name=(string)box;// here object type is explicitly converted to string type i.e. value type
            Console.WriteLine("value of name after unboxing :-"+name);
        }
    }
}
