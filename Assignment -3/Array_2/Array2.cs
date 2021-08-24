using System;

namespace Array_2
{
    class Array2
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 2D Array Example ");
            Console.WriteLine("Enter then value of n :- ");
            int n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter then value of m :- ");
            int m= Convert.ToInt32(Console.ReadLine());
            int [,] arr=new int[n,m];
            Console.WriteLine(" enter the values for Array:- ");
            for(int rw=0;rw<n;rw++){
                for(int cl=0;cl<m;cl++){
                    arr[rw,cl]=Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine(" Output ");
            for(int rw=0;rw<n;rw++){
                for(int cl=0;cl<m;cl++){
                    Console.Write(arr[rw,cl]+" "); 
                }
                Console.WriteLine();
            }
        }
    }
}
