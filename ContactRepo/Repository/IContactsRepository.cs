using ContactRepo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace ContactRepo.Repository
{
    public interface IContactsRepository
    {
        void Add(Contacts contacts);
        List<Contacts> GetAll();         //Not Recommended
        Contacts Find(int Id);           //Searching a record by Id and returning as a contact.
        void Update(Contacts contacts);  //We can update a record by Id or by Mail.
        void Remove(int Id);             //We are removing the record by Id and returning as a void.
    }
}