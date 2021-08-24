using System;

namespace interface_prog2
{
public  interface Tspeed{ //interface
    public void twoWheeler(int a); // by default abstract method 
    public void threeWheeler(int a);// by default abstract method
    public void fourWheeler(int a);// by default abstract method
}
    class Program:Tspeed
    {
        public void twoWheeler(int s)// decartion of function
        {
            Console.WriteLine("Speed for two wheeler  is set to "+s+" km/hr");
        }
        public void threeWheeler(int s)// decartion of function
        {
            Console.WriteLine("Speed for three wheeler  is set to "+s+" km/hr");
        }
        public void fourWheeler(int s)// decartion of function
        {
            Console.WriteLine("Speed for four wheeler  is set to "+s+" km/hr");
        }
        static void Main(string[] args)
        {
            var tsp=new Program(); //object declaration
            tsp.twoWheeler(60);
            tsp.threeWheeler(50);
            tsp.fourWheeler(40);
        }
    }
}
