using System;
using SundayClass.modele;
using SundayClass.ContactList;
using System.Collections.Generic;
namespace SundayClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact cobj=new Contact();
            cobj.Id=01;
            cobj.Name="maniram";
            ContactDetails obj=new ContactDetails();
            int t=obj.CreateContact(cobj);
            if (t==1)
            {
                Console.WriteLine("Value added");
            }
           
        }
    }
}
