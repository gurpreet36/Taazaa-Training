using System;

namespace PredicateDelegate
{
    class Program
    {
        public static void Main()
        {
            Predicate<string> isUpper = IsUpperCase;
            bool result = isUpper("hello world!!");
            Console.WriteLine(result);
        }
        
        public static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
    }
}
