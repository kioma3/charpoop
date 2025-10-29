using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class task8
    {
        public static void EightsTask()
        {
            Console.WriteLine("Введіть три сторони трикутника: ");

            double a = double.Parse(Console.ReadLine());

            double b = double.Parse(Console.ReadLine());

            double c = double.Parse(Console.ReadLine());

            if (a > b & a > c)
            {
                Console.WriteLine("Найдовша сторона: " + a);
            }
            else if (b > c)
            {
                Console.WriteLine("Найдовша сторона: " + b);
            }
            else
            {
                Console.WriteLine("Найдовша сторона: " + c);
            }
        }
    }
}
