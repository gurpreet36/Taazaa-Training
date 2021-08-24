using System;

namespace ActionDelegate
{
    class Program
    {
        public static void Main()
        {
            Action<int> ActionDel = ConsolePrint;
            ActionDel(25);
        }
	
        public static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }
    }
}
