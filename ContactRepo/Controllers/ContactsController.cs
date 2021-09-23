using Microsoft.AspNetCore.Mvc;
using ContactRepo.Repository;
using ContactRepo.Models;
namespace ContactRepo.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ContactsController:ControllerBase
    {
        IContactsRepository contactsRepository;
        public ContactsController(IContactsRepository _contactsRepository)
        {
            contactsRepository=_contactsRepository;
        }
        [HttpPost]
        public  IActionResult  CreateContact(Contacts contacts)
        {
            contactsRepository.Add(contacts);
            return Ok("Record saved");   
        }
         [HttpPut]
        public IActionResult UpdateContact(Contacts contacts)
        {
            contactsRepository.Update(contacts);
            return Ok("Recor has been updated ");
        }
            [HttpDelete("{Id}")]
        public IActionResult RemoveContact(int Id)
        {
            contactsRepository.Remove(Id);
            return Ok("Id is removed");
        }
        [HttpGet("{Id:int}")]

        public IActionResult Searchcontact(int Id)
        {
            var t=contactsRepository.Find(Id);
            return Ok(t);
        }
        [HttpGet("ContactList")]

        public IActionResult GetAllcontact()
        {
           var t =  contactsRepository.GetAll();
            return Ok(t);
        }
        
        
    }
}