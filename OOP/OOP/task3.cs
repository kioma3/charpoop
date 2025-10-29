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
            Console.WriteLine("Введіть річну заробітню плату від 1 до 10000");

            int salary = int.Parse(Console.ReadLine());

            int bills = 0;

            if (salary >= 1 & salary <= 10000)
            {
                if (salary >= 1 & salary <= 3000)
                {
                    bills = salary * 12 / 100;

                    Console.WriteLine($"Податок на дохід сягає {bills}");
                }
                else if (salary > 3000 & salary <= 7000)
                {
                    bills = salary * 15 / 100;

                    Console.WriteLine($"Податок на дохід сягає {bills}");
                }
                else
                {
                    bills = salary * 18 / 100;

                    Console.WriteLine($"Податок на дохід сягає {bills}");
                }
            }
        }
        }
    }
