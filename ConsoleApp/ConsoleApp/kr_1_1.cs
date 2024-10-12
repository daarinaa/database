using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr_1_1
{
    internal class kr_1_1
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 100 || num > 999)
            {
                Console.WriteLine("Введена некорректная форма.");
                Console.ReadKey();
                return;
            }

            int un = num % 10;
            int ten = (num / 10) % 10;
            int hund = num / 100;
            int sum = un + ten + hund;
            int prod = un * ten * hund;

            Console.WriteLine($"а) Кол-во единиц: {un}");
            Console.WriteLine($"б) Кол-во десятков: {ten}");
            Console.WriteLine($"в) Сумма цифр: {sum}");
            Console.WriteLine($"г) Произведение цифр: {prod}");
            Console.ReadKey();
        }
    }
}