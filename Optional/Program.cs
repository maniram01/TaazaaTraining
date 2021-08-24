using System;
using SpecialTopic.Modele;
namespace SpecialTopic
{

    // Params
    class Program
    {
        public static int Add(params int[] N)
        {
            int sum=0;
            foreach(int x in N)
            {
                sum=sum+x;
            }
            return sum;
        }
        static void Main()
        {
            int y=Add(2,4,5,7,8);
            Console.WriteLine(y);
             optional obj1=new  optional();
             
           
        }

        
    }
}
