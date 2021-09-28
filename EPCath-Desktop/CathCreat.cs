using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EPCath_Desktop
{

    public class CathCreat

    {
        string select_Type = "Тип катетера:";
        enum cath_type
        {
            ESO, DIA, ABL
        }

        public Catheter Cath_Type() // выбор кривизны катетера
        {
           // Catheter c1 = new Catheter();

           // cath_type types;
           // bool num = false;
           // types = Enum.Parse<cath_type>(c1.type, num);


            int i = 1;
            Console.WriteLine(select_Type);
            foreach (cath_type types in Enum.GetValues(typeof(cath_type)))
            {

                Console.WriteLine(i + ": " + types);
                i++;
            }
            
            string readType = Console.ReadLine();

            //switch (readType)
            {

              //  case "1":
                    CreatEsoCath cath_eso = new CreatEsoCath();
                    Catheter c1 = cath_eso.EsoDiam();
                   
                    //c1.type = cath_type.ESO.ToString();
                 //   break;
                    return c1;

                    /*case "2":
                        CreatDiaCath cath_dia = new CreatDiaCath();
                        Catheter c1 = cath_dia.EsoDiam();
                        return c1;
                        return c1;
                        break;

                    case "3":
                        CreatAblCath cath_abl = new CreatAblCath();
                        Catheter c1 = cath_abl.EsoDiam();
                        return c1;
                        return c1;
                        break;*/

            }
            

        }
        

    }
}









/*

if (c.type == Cath_type.ESO.ToString())

{
    Eso_curve curving;
    curving = Eso_curve._ER;
    c.curve = curving.ToString();
    //Console.WriteLine(c.curve);
}*/



























