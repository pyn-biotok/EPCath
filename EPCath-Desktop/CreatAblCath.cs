using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPCath_Desktop
{
    class CreatAblCath
    {

        enum Abl_curve
        {
            CO,
            JO,
            DA,
            CS
        }

        public CreatAblCath(string t)
        {
            Catheter c = new Catheter();
            c.type = t;
        }
    }
}
