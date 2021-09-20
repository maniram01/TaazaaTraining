using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using usermanagementService.Service;
using usermanagementService.Models;

namespace usermanagementService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController:ControllerBase
    {
        
    IUserRepository _IuserRepository;
    public UserController(IUserRepository IuserRepository)
    {
        _IuserRepository=IuserRepository;
    }

    [HttpPost]

    public IActionResult PostUsers(User user)
    {
        int result=_IuserRepository.Adduser(user);
        if(result!=null)
        {
            return Ok("saved");
        }
        return Forbid();
    }
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var user=_IuserRepository.SearchUser(id);
        if(user==null)
        {
            return NotFound();
        }
        return Ok(user);
    }

    [HttpPut("{id}")]
    
    public IActionResult updateuser(int id ,User user)
    {
        int res=_IuserRepository.UpdateUser(id,user);
        if(res!=0)
        {
            return Ok(res);
        }
        return NotFound();
    }
    [HttpDelete("{id}")]

    public IActionResult DeleteRecord(int id)
    {
        int res=_IuserRepository.DeleteUser(id);
        if(res!=null)
        {
            return Ok("Record Deleted");
        }
        return NotFound();
    }
    [HttpGet("UserList")]

    public IEnumerable<User> UserListRecord()
    {
        var Userrecord=_IuserRepository.GetUsers();
        return Userrecord;
    }
    }
}