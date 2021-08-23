using System;
using System.Collections.Generic;
using day8.Modele;
namespace day8
{
    class Program
    {
        static void Main(string[] args)
        {
            
           List<Employee> li1=new List<Employee>();
           li1.Add(new Employee{
              EId=40,
              EName="maniram yadav"

           });
           li1.Add(new Employee{
              EId=41,
              EName="maniram yadav"

           });
           li1.Add(new Employee{
              EId=42,
              EName="maniram yadav"

           });
           li1.Add(new Employee{
              EId=43,
              EName="maniram yadav"

           });
           for (int i=0; i<li1.Count; i++)
           {
               Console.WriteLine("Employee id="+li1[i].EId+"  "+"emplyee Name"+""+li1[i].EName);
           }
          
        }
    }
}
