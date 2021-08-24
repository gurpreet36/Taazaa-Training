using System;
using Day4A.Movie;
using Day4A.Study;
namespace Day4A
{
    class Program//PascalCase
    {
        static void Main(string[] args)
        {
            IMovie obj1=new Singh();//PascalCase
            IStudy obj=new Gurpreet();//PascalCase
            Console.WriteLine("i Study "+obj.Study(2)+" hrs at night");
            Console.WriteLine(obj1.Movie("Avengers") +" is my fav. movie");
            
        }
    }
}
