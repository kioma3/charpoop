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
            Console.WriteLine("Введіть букву");

            string symbol = Console.ReadLine();
            symbol = symbol.ToUpper();

            if (symbol == "A" || symbol == "E" || symbol == "I" || symbol == "O" || symbol == "U")
            {
                Console.WriteLine("Ця літера голосна");
            }
            else
            {
                Console.WriteLine("Ця літера приголосна");
            }
        }
    }
}
