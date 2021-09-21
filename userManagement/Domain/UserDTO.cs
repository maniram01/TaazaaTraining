using System;
namespace userManagement.Domain
{
    public class UserDTO // this should be in controller
    {
      
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public DateTime dateTime{get;set;}
       
    }
}