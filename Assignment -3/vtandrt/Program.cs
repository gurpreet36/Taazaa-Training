using System;

namespace vtandrt
{

    class Program
    {
        public static void ChangeValue(int x)
            {
                x =  200;
                Console.WriteLine(x);
            }
public static void Main(string[] args)
{
    int i = 100;

    Console.WriteLine(i);
    
    ChangeValue(i);
    
    Console.WriteLine(i);
}
    }
}
