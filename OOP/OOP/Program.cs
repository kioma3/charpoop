using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Animals;
using OOP.Figures;
using OOP.Fruits;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Завдання 1 ");
            Circle circle = new Circle { Radius = 5 };
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
            Console.WriteLine($"Circle Perimeter: {circle.CalculatePerimeter()}");

            Rectangle rect = new Rectangle { Width = 4, Height = 6 };
            Console.WriteLine($"Rectangle Area: {rect.CalculateArea()}");
            Console.WriteLine($"Rectangle Perimeter: {rect.CalculatePerimeter()}");

            Console.WriteLine("\n Завдання 2 ");
            Apple apple = new Apple { Name = "Apple", Variety = "Golden", Color = "Yellow" };
            Pear pear = new Pear { Name = "Pear", Variety = "Conference", Color = "Green" };

            Console.WriteLine($"Fruit: {apple.Name}, Variety: {apple.Variety}, Color: {apple.Color}");
            Console.WriteLine($"Fruit: {pear.Name}, Variety: {pear.Variety}, Color: {pear.Color}");

            Console.WriteLine("\n Завдання 3");
            Cat cat = new Cat("Black", 4.5f, 25.0f);
            Dog dog = new Dog("Brown", 12.0f, 15.0f);

            Console.WriteLine(cat.ToString());
            Console.WriteLine(cat.MakeSound());

            Console.WriteLine(dog.ToString());
            Console.WriteLine(dog.MakeSound());

            Console.ReadKey();
        }
    }
}
