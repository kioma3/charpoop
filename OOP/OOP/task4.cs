using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class task4
    {
        public static void FourthTask()
        {
            int[] numbers = { 30, -5, 58, 17, -24 };

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                    sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
