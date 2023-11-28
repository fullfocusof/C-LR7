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
        static void DirContent(DirectoryInfo DI, string path, string indent = "")
        {
            FileInfo[] FIs = DI.GetFiles();
            foreach (FileInfo file in FIs)
            {
                Console.WriteLine(indent + "Файл: " + file.Name);
            }

            DirectoryInfo[] DIs = DI.GetDirectories();
            foreach (DirectoryInfo dir in DIs)
            {
                Console.WriteLine(indent + "Каталог: " + dir.Name);
                DirContent(dir, dir.FullName, indent + "  ");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Укажите путь к каталогу");
            string path = Console.ReadLine();
            Console.WriteLine();

            DirectoryInfo DI = new DirectoryInfo(path);
            if(DI.Exists)
            {
                DirContent(DI, path);
            }
            else
            {
                Console.WriteLine("Каталог не найден");
            }
            Console.ReadLine();
        }
    }
}
