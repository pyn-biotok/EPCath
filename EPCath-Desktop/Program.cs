using System;

namespace EPCath_Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            Catheter c1 = new Catheter();

            Console.WriteLine("Выберите тип катетера: 1 - DIA, 2 - ABL"); // выбор типа катетера
            string type_read = Console.ReadLine();
                     
            switch (type_read)
            
            {
            case "1": // выбрана диагностика

                    c1.type = "DIA";

                   // c1.CreatDIACath();
                    Console.WriteLine("Выберите тип кривизны катетера: 1 - CS; 2 - CO; 3 - JO, 4 - DA"); // если выбрана диагностика, то сразу выбираем ее кривизну
                    type_read = Console.ReadLine();
                    switch (type_read)
                    {
                        case "1": // выбрана диагностика
                            c1.curve = "CS";
                            c1.cont_qty = "D"; // если выбран коронаярный синус - сразу указываем, тчо он может быть 10 полюсным
                            c1.shpac = "252";
                            goto m1;
                        break;

                        case "2":
                            c1.curve = "CO";
                          
                            break;

                        case "3":
                            c1.curve = "JO";
                            break;
                           
                        case "4":
                            c1.curve = "DA";
                            break;
                           

                    }
                   
                    c1.diam = "6"; // если выбрана диагностика, сразу показываем диаметр 6 Френч
                    c1.Cath_cont_qty(); // выбор количества контактных элементов
                    c1.Cath_shpac();

                   m1:  break;
               
            case "2" : // выбран абляционный тип катетера
                    c1.type = "ABL";
                    c1.Cath_irr();
                    if (c1.irr == "J") 
                        {
                        goto m2;
                    }
                    Console.WriteLine("Выберите тип кривизны катетера: 1 - SMALL; 2 - MEDIUM; 3 - LARGE");
                    type_read = Console.ReadLine();
                    switch (type_read)
                    {
                        case "1":
                            c1.curve = "SS";
                            break;

                        case "2":
                            c1.curve = "SM";
                            break;

                        case "3":
                            c1.curve = "SL";
                            break;
                    }
                            
                            c1.Cath_diam();
                            c1.cont_qty = "Q";
                            c1.shpac = "252";
                          
                            c1.Cath_d_tip();
                    break;
            }
                    
                   m2:  c1.CreateCath();
                       
                    }


            }
                                          

        }
    

