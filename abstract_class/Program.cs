using System;
namespace Day42.Abstract
{
    public abstract class Taazaa
    {
        public abstract void discipline();
    }
    public class Employee: Taazaa
    { 
        public override void discipline()
        {
            Console.WriteLine("i am");
        }
        public string hobby()
        {
            return "watching movie";
        }
        public static void Main()
        {
            var obj=new Employee();
            obj.discipline();
            string a= obj.hobby();
            Console.WriteLine(a);
        }
    }
}