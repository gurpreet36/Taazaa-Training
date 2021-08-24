using System;

namespace struct_prog
{
    public struct Person
{
    // Declaring different data types
    public string Name;
    public int Age;
    public int Weight;
 
}
    class Program
    {
        // Main Method
    static void Main(string[] args)
    {
 
        // Declare P1 of type Person
        Person P1;
 
        // P1's data
        P1.Name = "Gurpreet Singh";
        P1.Age = 22;
        P1.Weight = 70;
 
        // Displaying the values
        Console.WriteLine("Data Stored in P1 is " +
                           P1.Name + ", age is " +
                           P1.Age + " and weight is " +
                           P1.Weight);
 
    }
    }
}
