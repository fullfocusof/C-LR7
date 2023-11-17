using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите путь к каталогу");
            string path = Console.ReadLine();

            DirectoryInfo DI = new DirectoryInfo(path);
            if(DI.Exists)
            {
                DirectoryInfo[] DIs = DI.GetDirectories();
                FileInfo[] FIs = DI.GetFiles();

                Console.Clear();
                Console.WriteLine("Список каталогов:");
                foreach (DirectoryInfo dir in DIs)
                {
                    Console.WriteLine("-" + dir.Name);
                }
                Console.WriteLine("\nСписок файлов:");
                foreach (FileInfo file in FIs)
                {
                    Console.WriteLine("-" + file.Name);
                }
            }
            else
            {
                Console.WriteLine("Каталог не найден");
            }
            Console.ReadLine();
        }
    }
}
