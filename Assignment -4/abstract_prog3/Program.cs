using System;

namespace abstract_prog3
{
    public abstract class RBI{//abstract class 
        public abstract void accdetail(int acno,string name,string add,string actype);//abstract method
        public void minBalance(double a){
            Console.WriteLine("minimum balance required :- "+a);
        }
    }
    public class SBI:RBI
    {
        public override void accdetail(int acno, string name, string add, string actype)
        {
            Console.WriteLine("Acc no :- "+acno);
            Console.WriteLine("Acc Holder Name :- "+name);
            Console.WriteLine("Acc Type :- "+actype);
            Console.WriteLine("Acc Holder Address :- "+add);
        }
        
    }
    class Program:SBI
    {
        static void Main(string[] args)
        {
            var obj= new SBI();
            obj.accdetail(1576803,"Gurpreet Singh","New Delhi","Saving");
            obj.minBalance(3000);
        }
    }
}
