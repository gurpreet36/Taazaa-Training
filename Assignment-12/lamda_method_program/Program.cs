using System;
delegate void dobj(int a,int b); 

namespace lamda_method_program
{
    class Program
    {
        static void Main(string[] args)
        {
            dobj add=(int a, int b)=>
            {
                Console.WriteLine(a+b);
            };
            dobj sub=(int a, int b)=>
            {
                Console.WriteLine(a-b);
            };
                dobj mul=(int a, int b)=>
            {
                Console.WriteLine(a*b);
            };
                dobj div=(int a, int b)=>
            {
                Console.WriteLine(a/b);
            };
            add(10,20);
            sub(10,20);
            mul(10,20);
            div(10,20);

        }
    }
}
