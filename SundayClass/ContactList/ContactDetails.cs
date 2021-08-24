using SundayClass;
using SundayClass.modele;
using System;
using System.Collections.Generic;
namespace SundayClass.ContactList
{
    public class ContactDetails
    { 
        List<Contact> listobj=new List<Contact>();
        public int CreateContact(Contact obj)
        {
              listobj.Add(obj);
              return 1;
        }
        
    }
}