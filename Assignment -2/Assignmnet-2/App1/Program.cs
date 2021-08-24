using System;
using area;
using perimeter;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            area1 a=new area1();
            perimeter1 p= new perimeter1();
            
            Console.WriteLine("Area and perimeter of circle");
            Console.WriteLine("enter radius of circle");
            int r=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("area and perimeter of circle  is"+ a.area_circle(r)+" and "+p.peri_circle(r) );
            Console.WriteLine("Area and perimeter of rectangle");
            
            Console.WriteLine("enter length of rectangle");
            int l=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter width of rectangle");
            int b=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("area and perimeter of rectangle  is"+ a.area_rectangle(l,b) +" and "+p.peri_rectangle(l,b) );
            Console.WriteLine("Area and perimeter of square");
            Console.WriteLine("enter side :");
            int s=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("area and perimeter of square  is"+ a.area_sqr(s)+" and "+p.peri_sqr(s) );

        }
    }
}
