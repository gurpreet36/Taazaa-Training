using System;
using System.Collections;

namespace hashTableProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring hashtable
            Hashtable ht = new Hashtable();
            
            // insertion in hashtable
            ht.Add(1,"Gurpreet Singh");
            ht.Add(2,"Sandeep sir");
            ht.Add(3,"Ramesh");
            ht.Add(4,4.00);

            //update operation in hashtable
            Console.WriteLine("old value of 4 key : "+ht[4]);
            ht[4]=400;
            Console.WriteLine("new value of 4 key : "+ht[4]);

            //deletion operation in hashtable
            int n=ht.Count;
            Console.WriteLine("old ht contains "+n+" values");
            ht.Remove(4);
            n=ht.Count;
            Console.WriteLine("new ht contains "+n+" values");
            
            //search operation in hashtable
            if(ht.ContainsValue("Gurpreet Singh"))
            {
                Console.WriteLine("ht contains Gurpreet Singh value");
            }
        }
    }
}
