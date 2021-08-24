using System;

namespace jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            // can include two single array
            int[][] jA1 = new int[2][]; 
            jA1[0] = new int[3]{1, 2, 3};
            jA1[1] = new int[4]{4, 5, 6, 7 };
            Console.WriteLine(jA1[0][0]); //give value 1
            Console.WriteLine(jA1[0][1]); //give value 2
            Console.WriteLine(jA1[1][2]); //give value  6
            Console.WriteLine(jA1[1][3]); //give value 7

            // for two 2-d array
            int[][,] jb1 = new int[2][,]; 
            jb1[0] = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            jb1[1] = new int[2, 2] { { 7, 8 }, { 9, 10 } };
            Console.WriteLine(jb1[0][1, 1]); //returns 4
            Console.WriteLine(jb1[1][1, 0]); //returns 9
            Console.WriteLine(jb1[1][1, 1]); //returns 10
            
        }
    }
}
