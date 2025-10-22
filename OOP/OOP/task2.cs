using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class task2
    {
        public static void Second()
        {
            Console.WriteLine("Введіть дійсне число: ");

            double number = double.Parse(Console.ReadLine());

            int tempIntNumber = Convert.ToInt32(number);

            double tempDoubleNumber = number - tempIntNumber;

            tempDoubleNumber *= 100;

            int addend1 = Convert.ToInt32(tempDoubleNumber) / 10;

            double number2 = tempDoubleNumber * 1 / 10;

            int tempIntNumber2 = Convert.ToInt32(number2);

            double tempDoubleNumber2 = number2 - tempIntNumber2;

            tempDoubleNumber2 *= 10;

            int addend2 = Convert.ToInt32(tempDoubleNumber2);

            Console.WriteLine($"{addend1 + addend2}");
        }
    }
}
