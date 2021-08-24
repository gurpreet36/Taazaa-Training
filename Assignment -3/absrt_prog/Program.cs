using System;

namespace absrt_prog
{
    public abstract class Person_profile //abstract class
    {
        public abstract void person(string n); //abstract method 
        public void exp(int a)// non abstract method
        {
            Console.WriteLine("have an experience of "+a+" years");
        }
    }
    // creating new class and inheriting abstrarct class
    public class Taazaa_profile:Person_profile
    {
        public override void person(string n){
            Console.WriteLine("my  name  is "+n);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var obj=new Taazaa_profile();
            obj.person("Gurpreet");
            obj.exp(4);
        }
    }
}
