using System;

namespace day3
{ // constructor chaining


    class Hclinfosystem
    {
         public static void Main()
         {
            object x="maniram"; // x is  variable of object type
            string y=(string)x; //type conversion
            Console.WriteLine(y);

            // using dynamic
            dynamic x1="yadav";
            string y1=x1;
            Console.WriteLine(y1);
            

            // var 
            var x2="welcome"; // var x2
            Console.WriteLine(x2);

         }

        
        
    }
    
        
    
}
