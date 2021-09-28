using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPCath_Desktop
{
    
  public  class CreatDiaCath
    {

        enum Dia_curve
        {
            CO,
            JO,
            DA,
            CS
        }

        public CreatDiaCath(string t)
        {
            Catheter c = new Catheter();
            c.type = t;
        }


    }

   
}
