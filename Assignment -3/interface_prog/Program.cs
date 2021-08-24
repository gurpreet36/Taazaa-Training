using System;

namespace interface_prog
{
    public interface Area //now data type is fixed as int  
        {
            void area_circle(int r);// int type
            void area_rect(int l, int b);// int type
            void area_sqr(int s);// int type
        }
    class Program:Area
    {
        public void area_circle(int a){

            Console.WriteLine("Area of circle ="+(22/7)*a*a); 
        }
        public void area_rect(int a,int b){
            Console.WriteLine("Area of rectangle="+a*b);
        }
        public void area_sqr(int a){
            Console.WriteLine("Area of square="+a*a);
        }
                static void Main(string[] args)
        {
            var obj=new Program();
            obj.area_circle(10);
            obj.area_rect(10,20);
            obj.area_sqr(23);  
        }
    }
}
