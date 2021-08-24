using System;

namespace while_loop
{
    class while_loop_eg
    {
        static void Main(string[] args)
        {
            int count=1;
            string text="Made by Gurpreet Singh";
            int a=Convert.ToInt32(Console.ReadLine());
            while(count<=10){
                Console.WriteLine(a+" X "+count+" = "+a*count);
                count+=1;
            }
            Console.WriteLine(text);
        }
    }
}
