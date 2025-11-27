using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Person
    {
        private string name;
        private DateTime birthYear; 

        public string Name
        {
            get { return name; }
        }

        public DateTime BirthYear
        {
            get { return birthYear; }
        }


        public Person()
        {
            name = "Unknown";
            birthYear = DateTime.Now;
        }

        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }


        public int Age()
        {
            return DateTime.Now.Year - birthYear.Year;
        }

        public void Input()
        {
            Console.Write("Введіть ім'я: ");
            name = Console.ReadLine();

            Console.Write("Введіть дату народження (рік-місяць-день): ");
            if (!DateTime.TryParse(Console.ReadLine(), out birthYear))
            {
                Console.WriteLine("Неправильна дата");
                birthYear = DateTime.Now;
            }
        }

        public void ChangeName(string newName)
        {
            name = newName;
        }


        public override string ToString()
        {
            return $"Person: {name}, Дата народження: {birthYear.ToShortDateString()}, Вік: {Age()}";
        }

        public void Output()
        {
            Console.WriteLine(this.ToString());
        }

        public static bool operator ==(Person p1, Person p2)
        {
            if (ReferenceEquals(p1, null) && ReferenceEquals(p2, null)) return true;
            if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null)) return false;

            return p1.Name == p2.Name;
        }


        public static bool operator !=(Person p1, Person p2)
        {
            return !(p1 == p2);
        }


    }

}
