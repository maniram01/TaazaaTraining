using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ContactRepository.Models;
using ContactRepository.Repository;

namespace ContactRepository.Controllers
{
    [ApiController]
    [Route("Taazaa/[controller]")]
    public class ContactController :ControllerBase
    {
          IContactsRepository IcontactsRepository;
            public ContactController( IContactsRepository _IcontactsRepository)
        {
            IcontactsRepository=_IcontactsRepository;
        }
        [Route("Create")]
        [HttpPost]
       public async Task<IActionResult> CreateContact(Contact contact)
        {
            if(contact==null)
            {
                return BadRequest();
            }
           await IcontactsRepository.Add(contact);
           return Ok(contact);
        }
        [Route("FetchAll")]
        [HttpGet]
       public async Task<IActionResult> GetAllContact()
        {
            
          return Ok (await IcontactsRepository.GetAll());
           
        }
        [Route("Find")]
        [HttpGet]
       public async Task<IActionResult> FindAllContact(int x)
        {
            
          return Ok (await IcontactsRepository.Find(x));
           
        }

    }
}