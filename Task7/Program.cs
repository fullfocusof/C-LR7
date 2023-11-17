using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите путь к каталогу");
            string path = Console.ReadLine();

            DirectoryInfo DI = new DirectoryInfo(path);
            if (DI.Exists)
            {
                DirectoryInfo[] DIs = DI.GetDirectories();
                foreach (DirectoryInfo dir in DIs)
                {
                    dir.Delete(true);
                }
                Console.WriteLine("Все подкаталоги удалены");
            }
            else
            {
                Console.WriteLine("Каталог не найден");
            }
            Console.ReadLine();
        }
    }
}
