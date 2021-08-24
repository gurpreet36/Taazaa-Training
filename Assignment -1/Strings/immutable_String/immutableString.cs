using System;

namespace immutable_String
{
    class immutableString
    {
        static void Main(string[] args)
        {
            string a="Gurpreet";
            string b=a;
            // so in this case value of variable a i.e. Gurpreet is stored in pool memory and and variable b is pointing to that memory location in heap memory where value of a is stored
            a="Gurpreet Singh";
            // so now in this case variable a is pointing to new memory location in pool memory where Gurpreet Singh is stored instead of replacing its value at previous location
            Console.WriteLine(a+" (stored in new location ) , "+b+"(pointing to location 1)");

            
        }
    }
}
