using System;
delegate void dobj();
namespace Anonymous_Method
{
    class AnonymousMethodProgram
    {
        public static void Main()
        {
            dobj obj=delegate()
            {
                Console.WriteLine("Anonymous_Method work this way !!!!!");
            };
            dobj obj2=delegate()
            {
                int a=10;
                int b=20;
                Console.WriteLine("Anonymous add function result of A+B = "+a+b);
            };
            obj();
            obj2();

        }
    }
}
