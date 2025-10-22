using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class task6
    {
        public static void Sixth()
        {
            Console.WriteLine("Введіть число: ");

            int num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("Число парне!");
            }
            else
            {
                Console.WriteLine("Число непарне!");
            }
        }
    }
}
