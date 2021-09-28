using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPCath_Desktop
{
   public  class CreatEsoCath
    {
        string telect_Curve = "Тип кривизны дистальной части:";
        string select_Diam = "Диаметр катетера:";
        string select_Cont_qty = "Количество контактных элементов:";
        string select_shpac = "Межконтактное расстояние";
        string select_irr = "Наличие орошения";
        string select_Tip_length = "Длина дистального контактного элемента";

        enum eso_diam
        {
          SEVEN= 7, EIGHT = 8
        }


       

             public Catheter EsoDiam()
            {
            Catheter c = new Catheter();
            c.type = "ESO";
            c.curve = "ER";
                int i = 1;
                Console.WriteLine(select_Diam);
                foreach (eso_diam diam in Enum.GetValues(typeof(eso_diam)))
                {

                    Console.WriteLine(i + ": " + (int)diam);
                    i++;
                }

                string input_diam = Console.ReadLine();
                switch (input_diam)
                {
                    case "1":
                        c.diam = eso_diam.SEVEN.ToString();
                        c.cont_qty = "B";
                        c.shpac = "025";
                        c.irr = "N";
                        break;

                    case "2":
                        c.diam = eso_diam.EIGHT.ToString();
                        break;
                }
                return c;
            }
            
           
            

        }
    }

