using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class task4
    {
        int[] numb = new int[4];
        public static int MinMax(int[] numbers, out int max)
        {
            int min = numbers.Min();

            max = numbers.Max();

            return min;
        }
    }
}
