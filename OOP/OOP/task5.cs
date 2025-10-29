using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class task5
    {
        public static void FifthTask()
        {
            Console.WriteLine("Введіть число: ");

            int number = int.Parse(Console.ReadLine());

            int[] numbers = { 3, 5, 7, 8, 1, 2, 3, 2, 7 };

            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] == number)
                {
                    Console.WriteLine($"Найменший індекс вашого числа {i}");

                    break;
                }
        }
    }
}
