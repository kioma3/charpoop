using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class task6
    {
        public static double GeometryCalc(double x, double y, string figure)
        {
            switch(figure)
            {
                case "Прямокутник":
                    return x * y;
                case "Коло":
                    return 3.14 * x * x;
                case "Куб":
                    return 4 * x * x;
            }

            return 0.00;
        }
    }
}
