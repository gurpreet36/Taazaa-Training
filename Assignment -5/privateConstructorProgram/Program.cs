using System;

namespace privateConstructorProgram
{
    class Program
    {
        public static string name;
        public static int num;
        // Creating private Constructor
        // using private keyword
        private Program()
        {
        Console.WriteLine("Welcome to Private Constructor");
        }
        // Default Constructor
        // with parameters
        public Program(string a, int b) {
    
            name = a;
            num = b;
        }
        public static void Main() {
  
        // This line raises error because
        // the constructor is inaccessible
        // Program obj1 = new Program();
  
        // Here, the only default 
        // constructor will invoke
        Program obj2 = new Program("Gurpreet", 101);
  
        // Here, the data members of Geeks
        // class are directly accessed
        // because they are static members
        // and static members are accessed 
        // directly with the class name
        Console.WriteLine(Program.name + ", " + Program.num);
    }
            
    }
}
