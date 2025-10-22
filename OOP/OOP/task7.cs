using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class task7
    {
        public static void Seventh()
        {
            Console.WriteLine("Введіть градуси цельсія: ");

            double Celsium = double.Parse(Console.ReadLine());

            double Farenheit = Celsium + 32 * 5 / 9;

            Console.WriteLine("Градусів по Фаренгейту: " + Farenheit);
        }
    }
}
