using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class task2
    {
        public static void SecondTask()
        {

            int[] array = { 5, 4, 3, 4, 5 };

            for (int i = 0; i < array.Length / 2; i++)
            {
                
                if (array[i] != array[array.Length - 1 - i])
                {
                    Console.WriteLine("Масив не є паліндромом");

                    break;
                }
                else
                {
                    if (i == array.Length / 2 - 1)
                    {
                            Console.WriteLine("Масив є паліндромом");
                    }
                    else
                    {
                        continue;
                    }
                }        
            }
        }
    }
}
