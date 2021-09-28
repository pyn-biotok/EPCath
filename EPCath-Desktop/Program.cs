using System;
using System.Collections.Generic;
using System.Globalization;

namespace EPCath_Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
        

        Console.WriteLine(DateTime.Now); // вывод информации о сегодняшнем дне и времени

         
            Console.WriteLine("Введите количество  вариантов исполнения катетеров разных партий, вносимых в документ:");
            int Cath_qty = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < Cath_qty; i++)
            {

                CathCreat creator = new CathCreat();
              
                Catheter exemplar = creator.Cath_Type();

                Console.WriteLine(exemplar.cont_qty);

            }




        }


    }
}
    

