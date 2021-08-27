using System;

namespace Predicate_Delegate
{
    class Program
    {
        public static bool message(string mystring)
        {
            if (mystring.Length < 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public void Main()
        {
            Predicate<string> val = message;
            Console.WriteLine(val("Gurpreet Singh"));
        }
    }
}
