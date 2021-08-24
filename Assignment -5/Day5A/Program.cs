using System;
using System.Collections;
using Day5A.Recipe;

namespace Day5A
{
    class Program//pascal case
    {
        static void Main()
        {
            Console.WriteLine("for Mango Shake");
            var obj=new Recipe2cs();//camel case
            var arrayList=obj.mangoShake();//camel case
            int count=arrayList.Count;//camel case
            for(int i=0;i<count;i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            Console.WriteLine("for Banana Shake");
            var list=obj.bananaShake();//camel case
            count=list.Count;//camel case
            for(int i=0;i<count;i++)
            {
                Console.WriteLine(list[i].step + " "+list[i].rName);//camel case
            }  
        }
    }
}
