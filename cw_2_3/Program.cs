using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_2_3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.Write("Число должно быть положительным");
            }

            int steps = 0;

            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n = 3 * n + 1;
                }
                steps++;
            }
            Console.WriteLine($"Количество замен, необходимых для достижения 1: {steps}");
            Console.ReadKey();
        }
    }
}