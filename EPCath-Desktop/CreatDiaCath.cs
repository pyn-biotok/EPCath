using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPCath_Desktop
{
    
  public  class CreatDiaCath
    {
        string telect_Curve = "Тип кривизны дистальной части:";
        string select_Diam = "Диаметр катетера:";
        string select_Cont_qty = "Количество контактных элементов:";
        string select_shpac = "Межконтактное расстояние";
        string select_irr = "Наличие орошения";
        string select_Tip_length = "Длина дистального контактного элемента";

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
