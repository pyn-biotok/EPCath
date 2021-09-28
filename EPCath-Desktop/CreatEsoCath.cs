using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPCath_Desktop
{
    class CreatEsoCath
    {

        enum Eso_curve
        {
            CO,
            JO,
            DA,
            CS
        }

        public CreatEsoCath(string t)
        {
            Catheter c = new Catheter();
            c.type = t;
        }
    }
}
