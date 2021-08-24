using System;
using day7.Delegate;
delegate int customDelegate();
namespace day7
{
    class Program  // delegate concept
    {
        static void Main(string[] args)
        {
            var obj1=new Person();
            customDelegate cobj=new customDelegate(obj1.Phone);
            var temp=cobj.Invoke(); // for fun execute
            Console.WriteLine(temp);

            cobj+=obj1.Walk; // mutlti cat
            var temp1=cobj.Invoke(); // for fun execute
            Console.WriteLine(temp1);
           cobj+=obj1.Phone;
            
        }
    }
}
