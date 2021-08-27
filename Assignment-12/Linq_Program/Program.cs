using System;
using System.Linq;

namespace Linq_Program
{
    class Program
    {
        public  static void Main()
        {
            int[] n={1,2,3,4,5,9,8,7,6};
            // linq query is same as the query that we are using to fetch the data from table  in linque we basically use language integrated query
            // on the array to get the data as we want depend on query clause

            
            var resul= from i in n select i;
            foreach(var i in resul)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            //fetching data in the ascending order
            var result= from i in n orderby i ascending select i;
            foreach(var i in result)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            //fetching data in the desending order
            var result1= from i in n  orderby i descending select i;
            foreach(var i in result1)
            {
                Console.Write(i+" ");
            }
        }
    }
}
