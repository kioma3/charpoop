using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class task7
    {
        public static void SeventhTask()
        {
            Console.WriteLine("Введіть число: ");

            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Число є парним");
            }
            else
            {
                Console.WriteLine("Число є непарним");
            }

            if (number % 3 == 0)
            {
                Console.WriteLine("Число ділиться на 3");
            }
        }
    }
}
