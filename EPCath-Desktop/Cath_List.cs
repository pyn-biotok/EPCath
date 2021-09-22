using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPCath_Desktop
{
    class Cath_List
    {
        List<Catheter> CathList;

        public Cath_List()
        {
            CathList = new List<Catheter>();
             Catheter c = new Catheter();
            CathList.Add(c);
        }
    }
}
