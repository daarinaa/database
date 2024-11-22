using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_2_4
{
    class Complex
    {
        double _real;
        double _imaginary;

        public Complex(double real, double imaginary)
        {
            _real = real;
            _imaginary = imaginary;
        }

        public static Complex Add(Complex z1, Complex z2)
        {
            return new Complex(z1._real + z2._real, z1._imaginary + z2._imaginary);
        }

        public static Complex operator +(Complex z1, Complex z2)
        {
            return Add(z1, z2);
        }

        public static Complex Subtract(Complex z1, Complex z2)
        {
            return new Complex(z1._real - z2._real, z1._imaginary - z2._imaginary);
        }

        public static Complex operator -(Complex z1, Complex z2)
        {
            return Subtract(z1, z2);
        }

        public static Complex Multiply(Complex z1, Complex z2)
        {
            return new Complex(
                z1._real * z2._real - z1._imaginary * z2._imaginary,
                z1._real * z2._imaginary + z2._real * z1._imaginary);
        }

        public static Complex operator *(Complex z1, Complex z2)
        {
            return Multiply(z1, z2);
        }

        public static Complex Divide(Complex z1, Complex z2)
        {
            double denom = z2._real * z2._real + z2._imaginary * z2._imaginary;
            return new Complex(
                (z1._real * z2._real + z1._imaginary * z2._imaginary) / denom,
                (z1._imaginary * z2._real - z1._real * z2._imaginary) / denom);
        }

        public static Complex operator /(Complex z1, Complex z2)
        {
            return Divide(z1, z2);
        }

        public Complex Power(int exponent)
        {
            Complex result = new Complex(1, 0);
            Complex baseValue = this;
            while (exponent != 0)
            {
                if ((exponent & 1) == 1)
                {
                    result *= baseValue;
                }
                baseValue *= baseValue;
                exponent >>= 1;
            }
            return result;
        }

        public Complex Sqrt()
        {
            double magnitude = Math.Sqrt(Abs());
            double angle = Argument() / 2;
            return new Complex(
                magnitude * Math.Cos(angle),
                magnitude * Math.Sin(angle));
        }

        public double Abs()
        {
            return Math.Sqrt(_real * _real + _imaginary * _imaginary);
        }

        public double Argument()
        {
            return Math.Atan2(_imaginary, _real);
        }

        public override string ToString()
        {
            return $"{_real} + {_imaginary}i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex z1 = new Complex(3, 4);
            Complex z2 = new Complex(1, 2);

            Complex sum = z1 + z2;
            Console.WriteLine($"Сложение: {sum}");

            Complex difference = z1 - z2;
            Console.WriteLine($"Вычитание: {difference}");

            Complex product = z1 * z2;
            Console.WriteLine($"Умножение: {product}");

            Complex division = z1 / z2;
            Console.WriteLine($"Деление: {division}");

            Complex power = z1.Power(2);
            Console.WriteLine($"Возведение в степень: {power}");

            Complex sqrt = z1.Sqrt();
            Console.WriteLine($"Корень: {sqrt}");

            double abs = z1.Abs();
            Console.WriteLine($"Модуль: {abs}");

            double arg = z1.Argument();
            Console.WriteLine($"Угол: {arg}");
            Console.ReadKey();
        }
    }
}