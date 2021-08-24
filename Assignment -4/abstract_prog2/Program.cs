using System;

namespace abstract_prog2
{
    public abstract class Math{
        public abstract void classtime(int a);
       
    }
    class Program:Math
    {
        public override void classtime(int s)
        {
            Console.WriteLine("class time is "+s+" pm");
        }
         void scode(int b)
        {
            Console.WriteLine("subject code is :- "+b);
        }
        static void Main(string[] args)
        {
            var o=new Program();
            o.classtime(5);
            o.scode(101);
        }
    }
}
