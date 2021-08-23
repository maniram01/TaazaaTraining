using System;
using day8T.AdvDelegate;
//delegate string NameDelegate(string N);
//delegate void PhoneDelegate();
delegate bool StudyDelegate();


namespace day8T
{
    class Program
    {
        static void Main()
        {
            Study sobj=new Study();
            //NameDelegate nameDelegate=new NameDelegate(sobj.Name);
            //var n=nameDelegate.Invoke("maniram");
            //Console.WriteLine(n);
            Func<string,string> func=sobj.Name;
            string fob=func("maniram");
            Console.WriteLine(fob);
            // Action Delegate
            Action obj=sobj.PhoneNo;
            obj();
            // predicate 
            Predicate<string> predicate=sobj.StudyStatus;
            bool pd= predicate("bipin");
            Console.WriteLine(pd);
        }
    }
}
