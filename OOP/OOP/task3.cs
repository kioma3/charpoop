using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class task3
    {
        public static void Third()
        {
            Console.WriteLine("Введіть число: ");

            int h = int.Parse(Console.ReadLine());

            if (h >= 0 && h <= 6)
            {
                {
                    Console.WriteLine("Доброї ночі!");
                }
            }
            else if (h >= 7 && h <= 12)
            {
                Console.WriteLine("Доброго ранку!");
            }
            else if (h >= 13 && h <= 18)
            {
                Console.WriteLine("Доброго дня!");
            }
            else if (h >= 19 && h <= 24)
            {
                Console.WriteLine("Доброго вечора!");
            }
            else
            {
                Console.WriteLine("Число не підходить!");
            }
        }

        }
}
