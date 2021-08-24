using System;
using System.Collections.Generic;
using Assignment_10.Models;
namespace Assignment_10.ListManipulation
{
    public class ListManipulator:IListMainpulator
    {
        List<Contact> objList;

        public ListManipulator()
        {
            objList=new List<Contact>();
        }

        public void createList(Contact objContact)
        {
            objList.Add(objContact);
            Console.WriteLine("Added sucessfully");
        
        }

        public void updateList(int i,Contact objContact)
        {
            var temp= objList[i];
            temp.cName=objContact.cName;
            temp.cPhNo=objContact.cPhNo;
            temp.cLocation=objContact.cLocation;
            temp.cId=objContact.cId;
            temp.eMail=objContact.eMail;
            Console.WriteLine("Update sucessfully");
        }
         public void deleteListItem(int i)
        {
            objList.RemoveAt(1);
            Console.WriteLine("Deleted sucessfully");
        }


        public void DisplayList()
        {
            var n=0;
            foreach(var i in objList)
            {
                n++;
                Console.WriteLine(n+" "+i.cId+" "+i.cName+" "+i.cLocation+" "+i.cPhNo+" "+i.eMail);
            }
        }
    }
}