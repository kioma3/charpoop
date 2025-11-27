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
            Console.OutputEncoding = Encoding.UTF8;

            Circle circle1 = new Circle("Мале Коло", 5.0);
            Circle circle2 = new Circle("Велике Коло", 10.0);

            Square square1 = new Square("Малий Квадрат", 4.0);
            Square square2 = new Square("Великий Квадрат", 8.0);

            Shape[] shapes = { circle1, circle2, square1, square2 };

            Console.WriteLine("Інформація про фігури");
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Фігура: {shape.Name}");
                Console.WriteLine($"  Площа: {shape.Area():F2}");
                Console.WriteLine($"  Периметр: {shape.Perimeter():F2}");
                Console.WriteLine();
            }

            double maxCircleArea = (circle1.Area() > circle2.Area()) ? circle1.Area() : circle2.Area();
            string maxCircleName = (circle1.Area() > circle2.Area()) ? circle1.Name : circle2.Name;

            double maxSquareArea = (square1.Area() > square2.Area()) ? square1.Area() : square2.Area();
            string maxSquareName = (square1.Area() > square2.Area()) ? square1.Name : square2.Name;

            Console.WriteLine("Порівняння");
            Console.WriteLine($"Найбільше коло: \"{maxCircleName}\" з площею {maxCircleArea:F2}");
            Console.WriteLine($"Найбільший квадрат: \"{maxSquareName}\" з площею {maxSquareArea:F2}");

            Console.ReadKey();
        }
    }
}
