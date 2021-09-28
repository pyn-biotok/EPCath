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
        Catheter c = new Catheter();

     
       

       public  enum Cath_type
        {
            ESO, DIA, ABL
        }

        public enum Eso_curve
        {
            _ER, _1W, _2W
        }

        enum Abl_curve
        {
            
            SS,
            SM,
            SL
        }

        enum Dia_curve
        {
            CO,
            JO,
            DA,
            CS
        }

        public void Cath_forming() // формирвоание нового катетера
        {

      
            Cath_Type(); // пошли на выбор типа катетера
            Cath_Curve();

        }


        void Cath_Type() // выбор варианта исполнения катетера
        {
           

            Console.WriteLine("Выберите варинат исполнения катетера: 1 - ESO; 2 - DIA; 3 - ABL " );
              

            string readType = Console.ReadLine();
          

            switch (readType)
            {

                case "1":
                                                           
                    c.type = Cath_type.ESO.ToString(); ;
                    break;

                case "2":
                    
                    c.type = Cath_type.DIA.ToString(); ;
                    break;
                
                case "3":
                    
                    c.type = Cath_type.ABL.ToString(); ;
                    break;

            }

           
        }

      

        void Cath_Curve() // выбор кривизны катетера
        {
            
          
            switch (c.type)
            {

                case :
                    Eso_curve curving = Eso_curve._ER;
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

      
       
       

    

