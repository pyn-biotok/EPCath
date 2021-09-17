using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EPCath_Desktop
{
    class Catheter
    {

        public string type, curve, diam, shpac, irr;
        public string cont_qty, d_tip, LOT, SN;
        public DateTime dt;
        public void Cath_Info()
        {

            Console.WriteLine("Введи код партии изделия в формате '000':");
            string LOT = Console.ReadLine();

            
            string targetDateFormat = "MM/yyyy";
            Console.WriteLine("Введи дату изготовления изделия в формате ММ/ГГГГ:");

            string enteredDateString = Console.ReadLine();

            dt = DateTime.ParseExact(enteredDateString, targetDateFormat, CultureInfo.InvariantCulture);

            //Console.WriteLine(dt.ToString("MM/yyyy"));

            }

        public void CreateCath() // метод создания варианта исполнения катетера
        {
            Console.WriteLine("Выберите тип катетера: 1 - DIA, 2 - ABL"); // выбор типа катетера
            string type_read = Console.ReadLine();

            switch (type_read)

            {
                case "1": // выбрана диагностика

                    type = "DIA";

                    CreatDIACath();

                    break;

                case "2": // выбран абляционный тип катетера
                    type = "ABL";
                    CreatABLCath();
                    break;


            }
            

        }
        public void WriteCathType()
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
            Console.WriteLine("Серийный номер:" + LOT);
            Console.WriteLine("дата изготовления:" + dt.ToString("MM/yyyy"));
        }

        public Catheter()
        {
            Console.WriteLine("Создание варианта исполнения катетера");
        }

        public string Cath_irr() // проверка на наличие орошения
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

        public void CreatABLCath()
        {
       
            Cath_irr();
            if (irr == "J")
            {
                goto m2;
            }
            Console.WriteLine("Выберите тип кривизны катетера: 1 - SMALL; 2 - MEDIUM; 3 - LARGE");
            string type_read = Console.ReadLine();
            switch (type_read)
            {
                case "1":
                    curve = "SS";
                    break;

                case "2":
                    curve = "SM";
                    break;

                case "3":
                    curve = "SL";
                    break;
            }

            Cath_diam();
            cont_qty = "Q";
            shpac = "252";

            Cath_d_tip();
            Cath_Info();
        m2: WriteCathType();
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


        public void Cath_d_tip()
        {
            Console.WriteLine("Длина дистального контакта:  1 - 4 мм; 2 - 8 мм"); // проверка на наличие орошения
            string type_read = Console.ReadLine();
            switch (type_read)
            {
                
                case "1":
                    d_tip = "4";
                    break;

                case "2":
                    d_tip = "8";
                    break;

            }
        }
        public void CreatDIACath() // создание диагностического катетера
        {
            Console.WriteLine("Выберите тип кривизны катетера: 1 - CS; 2 - CO; 3 - JO, 4 - DA"); // если выбрана диагностика, то сразу выбираем ее кривизну
            string type_read = Console.ReadLine();
            switch (type_read)
            {
                case "1": // выбрана диагностика
                    curve = "CS";
                    diam = "6";
                    cont_qty = "D"; // если выбран коронаярный синус - сразу указываем, тчо он может быть 10 полюсным
                    shpac = "252";
                    goto m1;
                    break;

                case "2":
                    curve = "CO";

                    break;

                case "3":
                    curve = "JO";
                    break;

                case "4":
                    curve = "DA";
                    break;


            }

            diam = "6"; // если выбрана диагностика, сразу показываем диаметр 6 Френч
            Cath_cont_qty(); // выбор количества контактных элементов
            Cath_shpac();
            Cath_Info();
        m1: WriteCathType();

        }

       









    }



}

   
     

        

     

    

