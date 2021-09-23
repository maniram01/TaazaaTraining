using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using EmployeeService.Models;

namespace EmployeeService.Controllers
{
    [Route("[controller]")]     //for making the url
    public class PizzaController:ControllerBase
    {
        [HttpGet("info")]   //to make endpoint
        public List<Employee> Details()
        {
            List<Employee> obj = new List<Employee>();
            return obj;
        }
    }
}