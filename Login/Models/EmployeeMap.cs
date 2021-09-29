using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Login.Models
{
    public class EmployeeMap
    {
       public EmployeeMap(EntityTypeBuilder<Employee> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.UserName).IsRequired();
            entityTypeBuilder.Property(t => t.Password).IsRequired();
            
        }
    }
}