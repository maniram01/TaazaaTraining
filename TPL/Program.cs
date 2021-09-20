using System.Threading.Tasks;
using System.Threading;
using System;

namespace TPL
{
    class MyApp
    {
        public static void longTask()  // as DbContext
        {
           Thread.Sleep(20000);  // sleep for 2s
        } 
        public async static void MyCall() // Repository   await and aync are in pair
        {
          await Task.Run(new Action(longTask)); //task ke ander delegate hai
          System.Console.WriteLine("At this point new thread has been created ");
        }
         public static void Main()  // act as controller
        {
           MyCall();
           System.Console.WriteLine("I am main thread");
           Console.ReadLine();
           
        }
    }
}
