using System;

namespace FuncDelegate
{
    class Program
    {
        public static int SumOfNum(int x, int y)
        {
            return x + y;
        }
        
        public static void Main()
        {
            Func<int,int, int> add = SumOfNum;		
            int result = add(10, 20);
            Console.WriteLine(result); 
        }
    }
}
