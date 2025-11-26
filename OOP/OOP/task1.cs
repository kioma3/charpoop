using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class task1
    {
        public static double Calculator(double x, double y, string operation)
        {

            switch (operation)
            {
                case "+":
                    return x + y;
                case "-":
                    return x - y;
                case "*":
                    return x * y;
                case "/":
                    if (x != 0)
                    {
                        return x / y;
                    }
                    break;
                default: 
                    return x;
            }

            return 0.00;
        }
    }
}