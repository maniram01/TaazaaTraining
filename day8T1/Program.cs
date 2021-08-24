using System;
using day8T1.FileHandling;

namespace day8T1
{
   public class Program
    {
         public static void Main()
        {
            FileHandler fileHandler=new FileHandler(); // object name file handler
            fileHandler.writeToFile("I am maniram and doing training for");
             fileHandler.readFromFile();
        }
    }
}
