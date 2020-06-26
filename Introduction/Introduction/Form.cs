using System;
using System.Collections.Generic;
using System.Text;

namespace Activithree
{
    public class Form
    {
        public string firstName;
        public string lastName;
        public int age;
        public string profession;

        public void Input()
        {
            Console.WriteLine("\t\t\t== DATA FORM ==");

            Console.WriteLine("Enter your first name: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            string inputAge = Console.ReadLine();
            age = int.Parse(inputAge);

            Console.WriteLine("Enter your profession: ");
            profession = Console.ReadLine();
        }

        public void Introduce()
        {
            Console.WriteLine("\n\nMy name is {0} {1} and my age is {2}", firstName, lastName, age);
            Console.WriteLine("My profession is " + profession);
        }

    }
}
