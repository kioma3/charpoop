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

            Person[] people = new Person[6];

            Console.WriteLine("--- Введення даних про 6 осіб ---");
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"\nОсоба #{i + 1}:");
                people[i] = new Person(); 
                people[i].Input();        
            }

            Console.WriteLine("\n--- Ім'я та вік кожної особи ---");
            foreach (var person in people)
            {
                Console.WriteLine($"Ім'я: {person.Name}, Вік: {person.Age()}");
            }

            Console.WriteLine("\n--- Зміна імен для тих, хто молодше 16 ---");
            foreach (var person in people)
            {
                if (person.Age() < 16)
                {
                    person.ChangeName("Very Young");
                }
            }

            Console.WriteLine("\n--- Інформація про всіх осіб після змін ---");
            foreach (var person in people)
            {
                person.Output();
            }

            Console.WriteLine("\n--- Пошук осіб з однаковими іменами ---");
            bool foundDuplicate = false;
            
            for (int i = 0; i < people.Length; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    
                    if (people[i] == people[j])
                    {
                        Console.WriteLine($"Знайдено співпадіння: '{people[i].Name}' (Особа #{i + 1} та Особа #{j + 1})");
                        foundDuplicate = true;
                    }
                }
            }

            if (!foundDuplicate)
            {
                Console.WriteLine("Осіб з однаковими іменами не знайдено.");
            }

            Console.ReadKey();
        }
    }
}
