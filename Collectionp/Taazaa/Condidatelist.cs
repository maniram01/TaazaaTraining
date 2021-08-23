using System.Collections;
using System.Collections.Generic;
using Collectionp.Models;


namespace Collectionp.Taazaa
{
    class Program
    {

    
    public class Condidatelist
    {
        public ArrayList Condidatedetails()
        {
            ArrayList arrayList=new ArrayList();
            arrayList.Add("maniram");
            arrayList.Add("gaurav");
            arrayList.Add("bipin");
            return arrayList;
            
        }
     public  List<Condidate>  Condidatedetail()
        {
           
            List<Condidate> obj=new List<Condidate>();
            obj.Add(new Condidate{
                Cid=101,
                Cname="maniram"
            });

            obj.Add(new Condidate{
                Cid=102,
                Cname="bipin"
            });
            return obj;
        }
        }
    }
}
