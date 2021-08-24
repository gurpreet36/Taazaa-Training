using Day8.Models;
using System;
using System.Collections.Generic;
namespace Day8.ContactList
{
    public class ContactLists
    {
        List<Contact> obj; // Not Yet Memory is allocated it is an instance variable
        public ContactLists() // if object of class is created then memory allocation will take place from list it is constructor
        {
            obj=new List<Contact>();
        } 
        public void createContact()// it is member function for list creation
        {
            obj.Add(new Contact{
                cId=101,
                cName="Gurpreet Singh",
                cPhNo=9717983635,
                eMail="gurpreet@gmail.com",
                cLocation="Delhi"
                
            });
            obj.Add(new Contact{
                cId=102,
                cName="Ben",
                cPhNo=5363897179,
                eMail="ben@gmail.com",
                cLocation="Noida"
                
            });
            obj.Add(new Contact{
                cId=103,
                cName="Xaviour",
                cPhNo=1789783635,
                eMail="xm@gmail.com",
                cLocation="UP"
                
            });
            obj.Add(new Contact{
                cId=105,
                cName="Mickey",
                cPhNo=2717983635,
                eMail="mickey@gmail.com",
                cLocation="Delhi"
                
            });
            Console.WriteLine("Addition opertion done !!! ");
        }

        public void removalContact() // to remove element
        {
            obj.RemoveAt(1);
            Console.WriteLine("removing opertion done !!! ");
        }
        public void insertContact()
        {
            List<Contact> obj2=new List<Contact>();
            obj2.Add(new Contact{
                cId=111,
                cLocation="India",
                cPhNo=420,
                cName="Modi",
                eMail="CoModi@gmail.com"
            });
            obj.InsertRange(1,obj2);
            Console.WriteLine("Insertion opertion done !!! ");
        }
        public void updateContact()
        {
            var temp=obj[2];
            temp.cName="Tom Watson";
            Console.WriteLine("Update opertion done !!! ");
        }

        public void truncateContactList()
        {
            obj.Clear();
            Console.WriteLine("Contact List is reset is done !!! ");
        }
        public void displayContactList(){
            var n=0;
            foreach(var i in obj)
            {
                n++;
                Console.WriteLine(n+") "+i.cId+" "+i.cName+" "+i.cLocation+" "+i.cPhNo+" "+i.eMail);
            }
        }
    }
}