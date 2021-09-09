using System.Collections.Generic;
using ContactRepo.Models;
using System.Linq;

namespace ContactRepo.Repository
{
    public class ContactsRepository : IContactsRepository
    {
        int a=1;
        List<Contacts> listcontacts = new List<Contacts>();    //List contact is an object to perform the manipulation

        void IContactsRepository.Add(Contacts contacts)
        {
                    
            listcontacts.Add(contacts);
        }

        Contacts IContactsRepository.Find(int Id)
        {
            var contacts = listcontacts.Where(ctr=>ctr.EmployeeId==Id).SingleOrDefault();
            return contacts;
        }

        List<Contacts> IContactsRepository.GetAll()
        {
           
            if(a==1)
            {
                listcontacts.Add(new Contacts{
                EmployeeId = 768,
                EmployeeMail = "example@gmail.com",
                EmployeeName = "Karan"
            });
            listcontacts.Add(new Contacts{
                EmployeeId = 324,
                EmployeeMail = "example2@gmail.com",
                EmployeeName = "Rahul"
            });
            a=2;
            }


            return listcontacts;
        }

        void IContactsRepository.Remove(int Id)
        {
            var contactToRemove = listcontacts.Where(ctr=>ctr.EmployeeId==Id).SingleOrDefault();
            if(contactToRemove!=null)
            {
                listcontacts.Remove(contactToRemove);
            }
        }

        void IContactsRepository.Update(Contacts contacts)
        {
            var contactToUpdate = listcontacts.Where(ctr=>ctr.EmployeeId==contacts.EmployeeId).SingleOrDefault();
            if(contactToUpdate!=null)
            {
                contactToUpdate.EmployeeName = contacts.EmployeeName;
                contactToUpdate.EmployeeMail = contacts.EmployeeMail;
            }
        }
    }
}