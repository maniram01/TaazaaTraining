using System;
using List.Modele;
using System.Collections.Generic;
using System.Collections;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            /* List<int> list1=new List<int>();
            list1.Add(324324);
            list1.Add(433);
            list1.Add(333);
            list1.Add(32433324);
            list1.Add(34);
            for(int i=0; i<list1.Count; i++)
                {
                    Console.WriteLine(list1[i]);
                }
            var t1=list1.Contains(34);
            Console.WriteLine(t1); */
            var list1=new List<Contact>();
            // add operation
            list1.Add(new Contact
            {
                Eid=89,
                Ename="maniram",
                Enumber=877
                 }
            );
            for(int i=0; i<list1.Count; i++)
                {
                    Console.WriteLine("Eid="+list1[i].Eid+" "+"Ename="+list1[i].Ename+" "+"Enumber= "+list1[i].Enumber);
                }
                
                // remove
                list1.Remove(
                    new Contact{Eid=6456,Ename="yadav"}
                );
                for(int i=0; i<list1.Count; i++)
                {
                    Console.WriteLine("Eid="+list1[i].Eid+" "+"Ename="+list1[i].Ename+" "+"Enumber= "+list1[i].Enumber);
                }
        }
    }
}
