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

            List<Catheter> cath_list = new List<Catheter>();
            Console.WriteLine("Введите количество  вариантов исполнения катетеров разных партий, вносимых в документ:");
            int Cath_qty = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < Cath_qty; i++)
            {
                Catheter c = new Catheter();

                c.CreateCath();
                cath_list.Add(c);
            }




        }


    }
}
    

