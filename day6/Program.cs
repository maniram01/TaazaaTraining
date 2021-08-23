using System;
using day6.Models;

namespace day6
{
    class Program
    {
        static void Main(string[] args)
        {
             var obj=new Employee();
             
             obj.Employeeid=19;// set is working
             Console.WriteLine(obj.Employeeid); // get is working
             obj.EmployeeSalary=90000;
             Console.WriteLine(obj.EmployeeSalary);
             var obj1=new Supplier();
            
        }

    }
}
