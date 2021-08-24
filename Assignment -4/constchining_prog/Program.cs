using System;

namespace constchining_prog
{
    class Program
    {
        public Program()
        {
            Console.WriteLine("i am default constructor");
        }
        public Program(string b):this()
        {
            Console.WriteLine(b);
        } 
        static void Main(string[] args)
        {
            var obj=new Program("i am parameterized constructor");
        }
    }
}
