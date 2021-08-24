using System;

namespace Verbatim_String
{
    class verbatimString
    {
        static void Main(string[] args)
        {
            String @for="Gurpreet Singh";
            Console.WriteLine("value for @for : "+@for);
            foreach(char @in in @for){
                Console.Write(@in+"-");
            }
        }
    }
}
