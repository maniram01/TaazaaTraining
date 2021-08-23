using System;
using System.Collections;
using AdvanceArraylist.Modele;
using System.Collections.Generic;
namespace AdvanceArraylist
{
    class Program
    {
        static void Main(string[] args)
        {
          List< Employee> li1=new List< Employee>();
          // Add Element in List 
          li1.Add(new Employee
          {
             Eid=90,
             Ename="maniram yadav",
             EAge=20,
             ELocation="Noida"
          });
          li1.Add(new Employee
          {
             Eid=91,
             Ename="Gaurav",
             EAge=21,
             ELocation="Lucknow"
          });
          li1.Add(new Employee
          {
             Eid=93,
             Ename="Bipin",
             EAge=24,
             ELocation="Kanpur"
          });
          for(int i=0; i<li1.Count;i++)
          {
              Console.WriteLine("Employee id="+li1[i].Eid+", "+"Employee Name="+li1[i].Ename+","+"Employee Age="+li1[i].EAge+","+"Employee Location"+li1[i].ELocation);
          }
          // Contains  Function()
          Console.WriteLine (li1.Contains(new Employee
          {
             Eid=91,
             Ename="Gaurav",
             EAge=21,
             ELocation="Lucknow"
          }));
          // RemoveAt Function()
          li1.RemoveAt(2);
          for(int i=0; i<li1.Count;i++)
          {
              Console.WriteLine("Employee id="+li1[i].Eid+", "+"Employee Name="+li1[i].Ename+","+"Employee Age="+li1[i].EAge+","+"Employee Location"+li1[i].ELocation);
          }
          // updat Function
          var temp=li1[1];
          temp.EAge=25;
          temp.ELocation="Delhi";
          
          foreach(var x in li1)
          {
              Console.WriteLine("Employee id="+x.Eid+", "+"Employee Name="+x.Ename+","+"Employee Age="+x.EAge+","+"Employee Location="+x.ELocation);
          }
        }
    }
}
