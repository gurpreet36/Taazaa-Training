using System;

namespace do_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int count=1;
            string text="Made by Gurpreet Singh";
            int a=Convert.ToInt32(Console.ReadLine());
            do{
                Console.WriteLine(a+" X "+count+" = "+a*count);
                count+=1;
            }while(count<=10);
            Console.WriteLine(text);
        }
    }
}
