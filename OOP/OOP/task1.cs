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
            int[] numbers = { 23, 10, 3, 15 };

            double sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Середнє арифметичне: " + sum / numbers.Length);
        }
    }
}
