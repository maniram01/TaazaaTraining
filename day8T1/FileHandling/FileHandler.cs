using System;
using System.IO;

namespace day8T1.FileHandling
{
    public class FileHandler
    {
       public void writeToFile(string name)
       {
           FileStream f=new FileStream("Training.txt",FileMode.Create);
           StreamWriter s=new StreamWriter(f);
           s.WriteLine(name);
           s.Close();
           f.Close();
            
       } 
       public void readFromFile()
       {
          FileStream f=new FileStream("Training.txt",FileMode.Open);
          StreamReader reader=new StreamReader(f);
          string fileData= reader.ReadLine();

          Console.WriteLine(fileData);
          reader.Close();
          f.Close();
          Console.WriteLine("done");
       }   
    }
}