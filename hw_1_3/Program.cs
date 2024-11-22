using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите b: ");
            double b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите c: ");
            double c = Convert.ToInt32(Console.ReadLine());

            if (a != 0)
            {
                double d = b * b - 4 * a * c;

                if (d > 0)
                {
                    double answ1 = ((-b + Math.Sqrt(d)) / (2 * a));
                    double answ2 = ((-b - Math.Sqrt(d)) / (2 * a));
                    Console.WriteLine($"Два корня: {answ1}; {answ2}");
                }

                else if (d == 0)
                {
                    double answ = ((-b) / (2 * a));

                    Console.WriteLine($"Один корень: {answ}");
                }   

                else
                {
                    Console.WriteLine("Нет корней");
                }
            }

            else if (b != 0)
            {
                double answ = ((-c) / b);
                Console.WriteLine($"Один корень: {answ}");
            }

            else if (c != 0)
            {
                Console.WriteLine("Нет решений");
            }

            else
            {
                Console.WriteLine("Бесконечно много решений");
            }
            Console.ReadKey();
        }
    }
}