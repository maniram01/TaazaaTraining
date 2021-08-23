using System;
using ADBgeneric.Models;
using System.Collections.Generic;
namespace ADBgeneric.TrainingList
{
    public class TaazaaTrainingList
    {
       public List<Details> TrainingList()  //function
       {
           List<Details> obj=new List<Details>();
           obj.Add(new Details{
               Email="maigmail.com",
               PhoneNumber=1371283
           });
           obj.Add(new Details{
               Email="mgmail.com",
               PhoneNumber=9887878
           });
           return obj;

       }
      
    }
}