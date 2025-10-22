using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class task8
    {
        public static void Eights()
        {
            Console.WriteLine("Введіть число: ");

            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            while (n > 0)
            {
                sum += n;

                n--;
            }
            Console.WriteLine("Сума: " + sum);
        }
    }
}
