using System;
using Day8.ContactList;
using System.Collections.Generic;
using Day8.Models;

namespace Day8
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ContactLists obj=new ContactLists();
            //var temp=obj.createContact();
            Console.WriteLine("\n Current Status of list is empty !!!!");
            obj.createContact();
            Console.WriteLine();
            obj.displayContactList();
            Console.WriteLine();
            obj.removalContact();
            Console.WriteLine();
            obj.displayContactList();
            Console.WriteLine();
            obj.insertContact();
            Console.WriteLine();
            obj.displayContactList();
            Console.WriteLine();
            obj.updateContact();
            Console.WriteLine();
            obj.displayContactList();
            Console.WriteLine();
            obj.truncateContactList();
            Console.WriteLine();
            obj.displayContactList();
            Console.WriteLine();
            Console.WriteLine("All Operation work successfull !!!!");
            


        }                                           
    }
}
