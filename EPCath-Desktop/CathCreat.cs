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
        // задаем все подсказки для пользователя
        public string select_Type = "Тип катетера:";
        string select_Curve = "Тип кривизны дистальной части:";
        string select_Diam = "Диаметр катетера:";
        string select_Cont_qty = "Количество контактных элементов:";
        string select_shpac = "Межконтактное расстояние";
        string select_irr = "Наличие орошения";
        string select_Tip_length = "Длина дистального контактного элемента";

              
        public  enum Cath_type // типы катетеров
        {
            ESO, DIA, ABL
        }


        
        void Cath_Type() // метод выбора варианта исполнения катетера
        {
            
            int i = 1;
            Console.WriteLine(select_Type);
            foreach (Cath_type type in Enum.GetValues(typeof(Cath_type)))
            {
               
                Console.WriteLine(i + ": " + type);
                i++;
            }
             
            string readType = Console.ReadLine(); 
           

            switch (readType)
            {

                case "1":
                CreatEsoCath eso = new CreatEsoCath(Cath_type.ESO.ToString());
                break;

                case "2":
                CreatDiaCath dia = new CreatDiaCath(Cath_type.DIA.ToString());
                break;
                    
                case "3":
                CreatAblCath abl = new CreatAblCath(Cath_type.ABL.ToString());
                break;

            }

           
        }

      

        void Cath_Curve() // выбор кривизны катетера
        {
            Cath_type types;
            bool num = false;
            types = Enum.Parse<Cath_type>(c.type, num);

          
           switch (types)
            {
                
                case Cath_type.ESO:
                    Eso_curve curving = Eso_curve._ER;
                    break;

                case Cath_type.DIA:
                
                    break;

                case Cath_type.ABL:
                  //  Abl_curve curving = Eso_curve._ER;
                    break;

            }
           

            if (c.type == Cath_type.ESO.ToString())

            {

                Eso_curve curving;
                curving = Eso_curve._ER;
                c.curve = curving.ToString();
                //Console.WriteLine(c.curve);
            }

        }









    }
}

      
       
       

    

