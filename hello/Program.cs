using System;
using System.IO;
using System.Threading.Tasks;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\BIOTOK_3\Desktop\2";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();

            }
  
            Console.WriteLine("Введите имя файла");
            string filename = Console.ReadLine();

          //  static async Task Main(string[] args)
      //      {
        //        string date1 = ("Дата создания документа " + DateTime.Today);
          //      {
            //        using (StreamWriter swdate1 = new StreamWriter($"{path}\\{filename}.txt", true, System.Text.Encoding.Default));
              //      {
                //        await swdate1.WriteLineAsync(date1);
                  //  }
//                }
  //          }

            Console.WriteLine("Введите номер партии");
            string lot = Console.ReadLine();

            using (FileStream fstream = new FileStream($"{path}\\{filename}.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(lot);

                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Номер партии записан");

            }

            using (FileStream fstream = File.OpenRead($"{path}\\{filename}.txt"))
            {
                byte[] array = new byte[fstream.Length];

                fstream.Read(array, 0, array.Length);

                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"Номер парти из файла: {textFromFile}");
            }
            Console.ReadLine();
        }
    }
}
