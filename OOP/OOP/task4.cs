using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class task4
    {
        public static void Fourth()
        {
            Console.WriteLine("Введіть три числа: ");

            int num1 = int.Parse(Console.ReadLine());

            int num2 = int.Parse(Console.ReadLine());

            int num3 = int.Parse(Console.ReadLine());

            int tempmax;

            int tempmin;

            if (num1 > num2 && num1 > num3)
            {
                tempmax = num1;
            }
            else if (num2 > num3)
            {
                tempmax = num2;
            }
            else
            {
                tempmax = num3;
            }

            if (num1 < num2 && num1 < num3)
            {
                tempmin = num1;
            }
            else if (num2 < num3)
            {
                tempmin = num2;
            }
            else
            {
                tempmin = num3;
            }

            Console.WriteLine("Максимальне число: " + tempmax);
            Console.WriteLine("Мінімальне число: " + tempmin);

        }
    }
}
