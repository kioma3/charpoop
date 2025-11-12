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
            Car Maybach = new Car("Maybach", "red", 5000);

            Car gClass = new Car("G-class", "black", 4000);

            Car AmgS63 = new Car("AMG S63", "pink", 3000);

            Maybach.ChangePrice(10);

            gClass.ChangePrice(10);

            AmgS63.ChangePrice(10);

            Maybach.Print();

            gClass.Print();

            AmgS63.Print();


        }


    }

    class Car
    {
        private string name;

        private string color;

        private double price;

        private const string CompanyName = "Mercedes";

        public Car()
        {
            name = "Невідома назва";

            color = "Невідомий колір";

            price = 0;
        }

        public Car(string name, string color, double price)
        {
            this.name = name;

            this.color = color;

            this.price = price;
        }

        public void Input()
        {
            Console.WriteLine("Введіть назву машини: ");
            name = Console.ReadLine();

            Console.WriteLine("Введіть колір машини: ");
            color = Console.ReadLine();

            Console.WriteLine("Введіть ціну машини");
            price = double.Parse(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine($"Назва машини: {name}");

            Console.WriteLine($"Колір машини: {color}");

            Console.WriteLine($"Ціна машини: {price}");

            Console.WriteLine($"Марка машини: {CompanyName}");
        }

        public void ChangePrice(double x)
        {
            price = price * x / 100;
        }
    }
}
