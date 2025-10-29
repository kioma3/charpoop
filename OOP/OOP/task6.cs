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
            int[] numbers = { 5, -3, -7, 20, -2 };

            int result = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                    result *= numbers[i];
            }
            Console.WriteLine(result);
        }
    }
}
