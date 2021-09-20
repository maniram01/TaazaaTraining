using Microsoft.AspNetCore.Mvc;
namespace Rd.Controllers
{
    [ApiController]
      [Route("Taazaa[controller]")]
    public class UserController : ControllerBase
    { 
        [HttpGet]
        [Route("fetch/{id:int}")]
         public IActionResult  Singing(int? id)    //  IActionResult hav multiple helpin function
        {

            return Ok(id);
        }
    }
}