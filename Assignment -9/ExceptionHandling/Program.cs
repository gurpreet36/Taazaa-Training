using System;

namespace ExceptionHandling
{
    class DivideProg
    {
        int result;
      
        DivideProg()
        {
            result = 0;
        }
      
        public void division(int num1, int num2) 
        {
            try {
                result = num1 / num2;
            }
            catch (DivideByZeroException exc)
            {
                Console.WriteLine("Exception caught: {0}", exc);
            } 
            finally 
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
        
        static void Main(string[] args) {
            DivideProg div = new DivideProg();
            div.division(12, 0);
        }
    }
}
