using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LR7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("inputTask1.txt");
            StreamWriter sweven = new StreamWriter("outputTask1_1.txt");
            StreamWriter swodd = new StreamWriter("outputTask1_2.txt");

            while (!sr.EndOfStream) 
            {
                int value = int.Parse(sr.ReadLine());
                if(value % 2 == 0)
                {
                    sweven.WriteLine(value);
                }
                else
                {
                    swodd.WriteLine(value);
                }
            }

            sr.Close();
            sweven.Close();
            swodd.Close();

            Console.WriteLine("Данные успешно записаны");
            Console.ReadLine();
        }
    }
}
