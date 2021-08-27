using System;

namespace Func_Delegate
{
    class Program
    {
        static int Addition(int a, int b)
            {
                return a + b;
            }
        static int Multiplication(int a, int b)
            {
                return a * b;
            }
            
        static void Main(string[] args)
            {
                Func<int, int, int> mul = Multiplication;
                int result = mul(30, 10);
                Console.WriteLine(result);
                Func<int, int, int> add = Addition;
                int result1 = add(30, 10);
                Console.WriteLine(result1);
            }
    
    }
}
