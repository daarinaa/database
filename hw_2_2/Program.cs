using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace hw_2_2
{
    internal class Program
    {
        static BigInteger FactorialRecursive(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * FactorialRecursive(n - 1);
        }

        static BigInteger FactorialIterative(int n)
        {
            BigInteger result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        static BigInteger FibonacciRecursive(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        static BigInteger FibonacciIterative(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }

            BigInteger a = 0, b = 1;

            for (int i = 2; i <= n; i++)
            {
                BigInteger temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }

        static void Main()
        {
            Console.WriteLine("Введите число для подсчета факториала: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x < 0)
            {
                Console.WriteLine("Введено не целое число");
            }

            else
            {
                Console.WriteLine("Рекурсивный факториал " + FactorialRecursive(x));
                Console.WriteLine("Итеративный факториал " + FactorialIterative(x));
            }

            Console.WriteLine("Введите число для подсчета Фибоначчи: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Введено число <= 0");
            }

            else
            {
                Console.WriteLine("Рекурсивный Фибоначчи " + FibonacciRecursive(n));
                Console.WriteLine("Итеративный Фибоначчи " + FibonacciIterative(n));
            }
            Console.ReadKey();
        }
    }
}