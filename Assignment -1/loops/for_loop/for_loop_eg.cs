using System;

namespace for_loop
{
    class for_loop_eg
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter the no for which you want to print table:- ");
        int a=Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=10;i++){
            Console.WriteLine(a+" X "+i+" = "+a*i);
        }
        Console.WriteLine("Made by Gurpreet Singh");
        }
    }
}
