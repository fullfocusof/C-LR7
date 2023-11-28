using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
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
                FileInfo[] FIs = DI.GetFiles();
                foreach (FileInfo file in FIs)
                {
                    string newPath = file.LastWriteTime.Date.ToShortDateString();
                    DI.CreateSubdirectory(newPath);
                    file.MoveTo(path + "/" + newPath + "//" + file.Name);           
                }

                Console.WriteLine("Перемещение завершено");
            }
            else
            {
                Console.WriteLine("Каталог не найден");
            }
            Console.ReadLine();
        }
    }
}
