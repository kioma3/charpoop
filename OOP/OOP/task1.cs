using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class task1
    {
        public static void FirstTask()
        {
            Console.WriteLine("Введіть число");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("Число рівне нулю");
            }
            else if (number > 0)
            {
                Console.WriteLine("Число додатнє");
            }
            else
            {
                Console.WriteLine("Число від'ємне");
            }
        }
    }
}
