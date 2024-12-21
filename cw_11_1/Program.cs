using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cw_11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "f.txt";

            using (StreamWriter write = File.CreateText(file))
            {
                write.WriteLine("x sin(x)");

                for (double x = 0; x <= 1; x += 0.1)
                {
                    double sin = Math.Sin(x);
                    write.WriteLine($"{x:F1}\t{sin:F6}");
                }
            }
            Console.WriteLine($"Значения записаны в файл {file}");
            Console.ReadKey();
        }
    }
}