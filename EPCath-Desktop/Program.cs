using System;
using System.Collections.Generic;

namespace EPCath_Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            Catheter c1 = new Catheter();
            c1.CreateCath();
            
            Catheter c2 = new Catheter();
            c2.CreateCath();
           
            List<Catheter> cath_list = new List<Catheter>();

            cath_list.Add(c1);
            cath_list.Add(c2);
        }


    }
}
    

