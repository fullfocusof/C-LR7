using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("inputTask2.txt");
            StreamWriter sw = new StreamWriter("outputTask2.txt");

            while (!sr.EndOfStream)
            {
                char c = (char)sr.Read();
                if(c == 'z')
                {
                    c = 'a';
                }
                else if(char.IsLetter(c))
                {
                    c = (char)(c + 1);
                }
                sw.Write(c);
            }

            sr.Close();
            sw.Close();

            Console.WriteLine("Данные успешно записаны");
            Console.ReadLine();

        }
    }
}
