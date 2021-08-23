using System;

namespace Delegate
{
    class Program
    {
        public void F1()
        {
            Console.WriteLine("instance function");
        }
        public static void F2()
        {
            Console.WriteLine("static function");
        }
        static void Main(string[] args)
        {
           Program obj=new Program();
           obj.F1();
         Program.F2();

        }
    }
}
