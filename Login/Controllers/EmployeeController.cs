using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Login.Models;
using Login.Repository;


namespace Login.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class EmployeeController :ControllerBase
    {
        IEmployee entity;
            public EmployeeController(IEmployee _entity)
             {
                entity=_entity;
            }

        [Route("CreateAccount")]
        [HttpPost]
        public  IActionResult CreateContact(Employee employee)
        {
            
            return Ok(entity.Add(employee));

        }
        [Route("Login")]
        [HttpGet]
        public  IActionResult fetchData(string username, string password)
        {
            var r=entity.Login(username,password);  
            if(r==null)
            {
                return Ok("Invalid username and password");
            }
            return Ok ("Login Successfull ");
            
        }
    }
}