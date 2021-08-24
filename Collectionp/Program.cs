using System;
using Collectionp.Taazaa;
using System.Collections;
using Collectionp.Models;
using static Collectionp.Taazaa.Program;

namespace Collectionp
{
    class Program
    {
        static void Main()
        {
            /* ar obj=new Condidatelist();
            var arrayList=obj.Condidatedetails();
            int count =arrayList.Count;
            for(int i=0; i<count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }  */
            var objlist=new Condidatelist();
            var list=objlist.Condidatedetail();

            int count =list.Count;
            for(int i=0; i<count; i++)
            {
                Console.WriteLine(list[i].Cid+" "+list[i].Cname);
            } 

            
            
            
        }
    }
}
