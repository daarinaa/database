using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_2_4
{
    internal class Program
    {
        static void BubbleSort(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
                Print(array);
            }
        }
        public static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] array = { 90, 60, 33, 11, 2, 56};

            Console.WriteLine("Исходный массив:");
            Console.WriteLine(string.Join(" ", array));

            BubbleSort(array);

            Console.WriteLine("Отсортированный массив:");
            Console.WriteLine(string.Join(" ", array));
            Console.ReadKey();
        }
    }
}
