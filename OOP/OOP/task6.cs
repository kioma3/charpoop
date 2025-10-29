using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class task6
    {
        public static void SixthTask()
        {
            Console.WriteLine("Введіть кількість років");

            int age = int.Parse(Console.ReadLine());

            if (age >= 12 & age <= 18)
            {
                Console.WriteLine("Вік є підлітковим");
            }
        }
    }
}
