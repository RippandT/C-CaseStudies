using System;
using System.Collections.Generic;
using System.Text;

namespace week3_class
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;

        public void Introduce()
        {
            Console.WriteLine("Hi my name is {0} {1} and I am {2} years old", firstName, lastName, age);
        }
    }
}
