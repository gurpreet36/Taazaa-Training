using System;
using AdvanceDeligate.Type; 

delegate void Cal(double x,double y);

namespace AdvanceDeligate
{
    class Program
    {
        public static void Main()
        {
        
            TypeOfOperation obj;
            Console.WriteLine("\n _______Calculator_______ \n Enter value of No1 :- ");
            double a=Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("\n Enter value of No2 :- ");
            double b=Convert.ToDouble(Console.ReadLine());
            
            obj=new TypeOfOperation(a,b);

            string uCh="Y";
            Console.WriteLine("________ Menu ________\n Press 1: Delegate Type \n Press 2: Anonymous Type \n Press 3: Lamda Function Type  \n Press 4:  Exit to main menu ");
            while(uCh=="Y" || uCh=="y")
            {  
                Console.WriteLine("Enter your Choice :-");
                int ch=Convert.ToInt32(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        obj.delegateType();
                        break;
                    case 2:
                        obj.anonymousType();
                        break;
                    case 3:
                        obj.lamdaType();
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("Do You Want To Continue ... Press Y else press any key to exit : ");
                uCh=Console.ReadLine();

            } 
        }
    }
}
