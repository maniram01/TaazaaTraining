using System;
using  Misclleneous.IT;

namespace Misclleneous
{
    class Program
    {
        static void Main(string[] args)
        {
            var Mohan=new Taazaa(101,10000);
            var Maniram=new Taazaa(102,1200);
            var Bipin=new Taazaa(103,13000);
            var sal=Mohan.EmployeeSalary();
            Console.WriteLine(sal);
            var sal1=Maniram.EmployeeSalary();
            Console.WriteLine(sal1);   

            var cof=Taazaa.Coffeehouse();
            Console.WriteLine(cof);

            Console.WriteLine(Taazaa.Coffeehouse());
        }
    }
}
