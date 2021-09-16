using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPCath_Desktop
{
    class Catheter
    {
        public string type, curve, diam, shpac, irr;
        public string cont_qty, d_tip;

        public void CreateCath()
        {
            switch (type)
            {
                case "DIA":
                    Console.WriteLine("BIOTOK" + " " + type + "." + curve + "6" + cont_qty + shpac + "N");
                    break;
                
                case "ABL":
                    Console.WriteLine("BIOTOK" + " " + type + "." + curve + "6" + cont_qty + shpac + "N");
                    break;
            }
            
        }

        

     

    }
}
