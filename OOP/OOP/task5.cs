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
            Console.WriteLine("Введіть три чсила:");

            int number1 = int.Parse(Console.ReadLine());

            int number2 = int.Parse(Console.ReadLine());

            int number3 = int.Parse(Console.ReadLine());

            if (number1 > number2 & number1 > number3)
            {
                Console.WriteLine("Найбільше число: " + number1);
            }
            else if (number2 > number3)
            {
                Console.WriteLine("Найбільше число: " + number2);
            }
            else
            {
                Console.WriteLine("Найбільше число: " + number3);
            }


        }
    }
}
