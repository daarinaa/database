using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_7_1
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введите число:");

            try
            {
                string input = Console.ReadLine();
                int numb = ConvertToInt(input);
                Console.WriteLine($"Число = {numb}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static int ConvertToInt(string input)
        {
            try
            {
                return int.Parse(input);
            }
            catch (FormatException)
            {
                throw new FormatException("Введено некорректное значение. Введите число");
            }
            catch (OverflowException)
            {
                throw new OverflowException("Введено некорректное значение. Число выходит за пределы от -2,147,483,648 до 2,147,483,647");
            }
        }
    }
}