using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("inputTask3.txt");
            StreamWriter sw = new StreamWriter("outputTask3.txt");

            while (!sr.EndOfStream)
            {
                
            }

            sr.Close();
            sw.Close();

            Console.WriteLine("Данные успешно записаны");
            Console.ReadLine();
        }
    }
}
