using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class task5
    {
        public static void Fifth()
        {
            Console.WriteLine("Введіть довжину: ");

            double lenght = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть ширину: ");

            double width = double.Parse(Console.ReadLine());

            double area = width * lenght;

            Console.WriteLine("Площа прямокутника: " + area);
        }
    }
}
