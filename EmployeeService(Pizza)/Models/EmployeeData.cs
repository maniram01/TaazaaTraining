using System.Collections.Generic;
namespace EmployeeService.Models
{
    public class EmployeeData
    {
        public List<Employee> EmployeeDetails()
        {
            List<Employee> obj = new List<Employee>();
            obj.Add(new Employee{
                phno=4654,
                name="Deepti"
            });
            obj.Add(new Employee{
                phno=8654,
                name="Rahul"
            });
            return obj;
        }
    }
}