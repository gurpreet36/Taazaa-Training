using System;
using System.Collections.Generic;

namespace dictonaryProgram
{
    class Program //implementation of all operations of dictionary
    {
        static void Main(string[] args)
        {
            //declaration of Dictionary
            var dt=new Dictionary<string,object>(); //here key is string type and value is of object type
    
            //Insertion operation in Dictionary
            //inserting value in dt
            dt.Add("Eid",101);
            dt.Add("Ename","Gurpreet Singh");
            dt.Add("Ephno",9717983635);
            dt.Add("Esalary",1000000.00);


            //update operation in Dictionary
            //update Ephno value
            
            Console.WriteLine("ephno old value :- "+dt["Ephno"]);
            dt["Ephno"]=7827656364;
            Console.WriteLine("ephno new value :- "+dt["Ephno"]);
            
            //delete operation in Dictionary
            int count=dt.Count;
            Console.WriteLine("old dt contains "+count+" elements");
            dt.Remove("Ephno");
            count=dt.Count;
            Console.WriteLine("new dt contains "+count+" elements");
            
            //search operation in Dictionary
            var val="Gurpreet Singh";
            if(dt.ContainsValue(val))
            {
                Console.WriteLine(val+"is found in dt");
            }
            
        }
    }
}
