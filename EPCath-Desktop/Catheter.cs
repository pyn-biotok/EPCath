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

        public Catheter()
        {
            Console.WriteLine("Создание варианта исполнения катетера");
        }

        public void CreatDIACath()
        {

}

        public void CreateCath() // метод создания варианта исполнения катетера
        {
            switch (type)
            {
                case "DIA":
                    Console.WriteLine("BIOTOK" + " " + type + "." + curve + "6" + cont_qty + shpac + "N");
                    break;

                case "ABL":
                    Console.WriteLine("BIOTOK" + " " + type + "." + curve + diam + cont_qty + shpac + irr + d_tip);
                    break;
            }

        }

        public void Cath_diam()
        {
            Console.WriteLine("Выберите диаметр катетера: 1 - 6F; 2 - 7.5F"); // выбор диаметра катетера
            string type_read = Console.ReadLine();
            switch (type_read)
            {
                case "1":
                    diam = "6";
                    break;

                case "2":
                    diam = "75";
                    break;

            }
        }

        public void Cath_cont_qty()
        {
            Console.WriteLine("Количество контактов: 1: 2 контакта; 2: 4 контакта; 3: 10 контактов"); // выбор межконтактного расстояния
            string type_read = Console.ReadLine();
            switch (type_read)
            {
                case "1":
                    cont_qty = "B";
                    break;

                case "2":
                    cont_qty = "Q";
                    break;

                case "3":
                    cont_qty = "D";
                    break;
            }
        }

        public void Cath_shpac()
        {
            Console.WriteLine("Межконтаткное расстояние: 1: 5 мм; 2: 2-5-2 мм"); // выбор межконтактного расстояния
            string type_read = Console.ReadLine();
            switch (type_read)
            {
                case "1":
                    shpac = "005";
                    break;

                case "2":
                    shpac = "252";
                    break;

            }
        }

        public string Cath_irr()
        {
            Console.WriteLine("Наличие орошения: 1 - ДА; 2 - НЕТ"); // проверка на наличие орошения
            string type_read = Console.ReadLine();
            switch (type_read)
            {
                case "1":
                    curve = "SM";
                    diam = "75";
                    cont_qty = "Q";
                    shpac = "252";
                    irr = "J";
                    d_tip = "35";
                    return irr;
                    break;


                case "2":
                    irr = "N";
                    Cath_d_tip();
                    return irr;
                    break;


                     }
            return irr;
        } 
        public void Cath_d_tip()
        {
            Console.WriteLine("Длина дистального контакта: 1 - 3,5 мм; 2 - 4 мм; 3 - 8 мм"); // проверка на наличие орошения
            string type_read = Console.ReadLine();
            switch (type_read)
            {
                case "1":
                    d_tip = "35";
                    break;

                case "2":
                    d_tip = "4";
                    break;

                case "3":
                    d_tip = "8";
                    break;
            
            }
        }
    }
}
   
     

        

     

    

