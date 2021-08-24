using System;
using FunDelegate.Modele;
namespace FunDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Employeecs employeecs=new Employeecs();
            Func<string,string> func=employeecs.Name;
            string s1= func("maniram");
            Console.WriteLine(s1);
            Action<int> action=employeecs.age;
            action(2);
            Predicate<int> predicate=employeecs.Status;
            bool b1=predicate(3);
            Console.WriteLine(b1);
        }
    }
}
