using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FisrtTask();
            //task2.Second();
            //task3.Third();
            //task4.Fourth();
            //task5.Fifth();
            //task6.Sixth();
            //task7.Seventh();
            //task8.Eights();
        }

        public static void FisrtTask()
        {
            Console.WriteLine("Введіть день: ");

            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть місяць: ");

            int number2 = int.Parse(Console.ReadLine());

            if (number1 <= 31 && number2 <= 12)
            {
                Console.WriteLine(number1 + "." + number2);
            }
            else
            {
                Console.WriteLine("Число не дійсне");
            }

        }
    }
}
