using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Login.Models
{
    public class EmployeeDbContext :DbContext
    {
        public  DbSet<Employee> Login{get;set;}    //

        public EmployeeDbContext(DbContextOptions options) :base(options)
        {
            
        }
    
    }
}