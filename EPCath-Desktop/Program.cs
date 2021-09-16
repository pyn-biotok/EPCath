using System;

namespace EPCath_Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            Catheter c1 = new Catheter();

            Console.WriteLine("Выберите тип катетера: /n1 - DIA, 2 - ABL");
            string type_read = Console.ReadLine();
            switch (type_read)
            
            {
                case "1":
                    
                    c1.type = "DIA";
                    Console.WriteLine("Выберите тип кривизны катетера: 1 - CS; 2 - CO; 3 - JO, 4 - DA");
                    type_read = Console.ReadLine();
                    switch (type_read)
                    {
                        case "1":
                            c1.curve = "CS"; 
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
                    break;
                
                        case "2" :
                    c1.type = "ABL";
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
                    break;
                
          
            }
           
            Console.WriteLine("BIOTOK" + " " + c1.type + "." + c1.curve);

            /*Console.WriteLine("Введите диаметр катетера");
            c1.diam = Console.ReadLine();

            Console.WriteLine("Введите межконтактное расстояние");
            c1.shpac = Console.ReadLine();

            Console.WriteLine("Наличие орошения: N - нет, J - да");
            c1.irr = Console.ReadLine();*/
            


        }
    }
}
