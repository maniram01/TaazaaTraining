using System;
using ADBgeneric.TrainingList;
using ADBgeneric.Models;
using System.Collections.Generic;

namespace ADBgeneric
{
    class Program
    {
        static void Main()
        {
            var obj=new TaazaaTrainingList();
            List<Details> temp= obj.TrainingList();
            int t=temp.Count;
            for(int i=0; i<t; i++ )
            {
                Console.WriteLine(temp[i].Email+""+temp[i].PhoneNumber);
            }
        }
    }
}
