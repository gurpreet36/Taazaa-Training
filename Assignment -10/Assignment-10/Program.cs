using System;

namespace Assignment_10
{
    class Program
    {
        public static void Main()
        {
            string cm="Y";
            while(cm=="Y" ||cm=="y")
            {
                Console.WriteLine("______Taazaa Menu________\n Press 1: Create Employee \n Press 2: Update Employee \n Press 3: Delete Employee \n Press 4: Display Employee \n Press 5: Exit from menu \n enter your Choice :-");
                int ch=Convert.ToInt32(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        Console.WriteLine(" ok Created.....");
                        break;
                    case 2:
                        Console.WriteLine(" ok updated.....");
                        break;
                    case 3:
                        Console.WriteLine(" ok deleted.....");
                        break;
                    case 4:
                        Console.WriteLine(" ok program exit .......");
                        break;
                    case 5:
                        Console.WriteLine(" ok program exit .......");
                        break;
                    default:
                        Console.WriteLine("Invalid choice try again");
                        break;

                }
                Console.WriteLine("Do you want to continue...... press Y else Press any key :-");
                cm=Console.ReadLine();
            }
        }
            
    }
}
