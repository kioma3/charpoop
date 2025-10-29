using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class task3
    {
        public static void ThirdTask()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
