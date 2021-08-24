using System;

namespace Strings_methods
{
    class stringMethod
    {
        static void Main(string[] args)
        {
            String a=Console.ReadLine();
            Console.WriteLine("value of a in Upper case :- "+a.ToUpper());
            Console.WriteLine("value of a in lower case :- "+a.ToLower());
            Console.WriteLine("value of a in without whitespace at end :- "+a.Trim());
            String b=Console.ReadLine();
            Console.WriteLine("concat value of b to a :- "+string.Concat(a,b));
            Console.WriteLine("to check equality of a and b  :- "+a.Equals(b));
            Console.WriteLine("enter the value that u want to replace in a:-");
            String c=Console.ReadLine();
            Console.WriteLine("with new value :- ");
            String d=Console.ReadLine();
            Console.WriteLine("value of a :-"+a.Replace(c,d));
            Console.WriteLine("enter the value that u want to insert in a "+"at position :- 2"+":-");
            c=Console.ReadLine();
            Console.WriteLine("value of a :-"+a.Insert(2,c));
            
            
        }
    }
}
