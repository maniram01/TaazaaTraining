using System;
using AdvanceDelegate.Arithemetic;
delegate void ArithemeticDelegate(double D1,double D2);
namespace AdvanceDelegate
{
    class Program
    {
        static void Main()
        {
            /* ArithemeticDelegate obj=new ArithemeticDelegate(ArithemeticOperation.Addition);
            // obj.Invoke(3,6); // invoke Fun will  call Addtion Fun
            obj+=ArithemeticOperation.Multiply;
            obj.Invoke(9,6); */ 


            // Anonyumous
            ArithemeticDelegate mydel=(double d1,double d2)=> // lambda Expression
            {
                Console.WriteLine(d1*d2);
            };
            ArithemeticDelegate dive=delegate(double d1,double d2) // Anonymous Function
            {
                Console.WriteLine(d1/d2);
            };
            mydel(10,5);
            dive(10,2);
    
        }
    }
}
