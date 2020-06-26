using System;
using week3_class.Math;

/*
 * - Week 3 of our class
 * - Introduction to non-primitives, among other things
 */

namespace week3_class
{
    class AddNumbers
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person1 = new Person();

            person.firstName = "Ripp";
            person.lastName = "Terr";
            person.age = 18;

            person1.firstName = "Rippand";
            person1.lastName = "Terrence";
            person1.age = 100000000;

            int result = Calculator.Add(5, 5);
            int result2 = Calculator.Add(1, 1);

            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            string[] names = new string[3] { "Coby", "Rippand", "Blast" };

            string firstName = "Ripp";
            string lastName = "Terr";
            string name = string.Format("{0} {1}", firstName, lastName);
            string list = string.Join("_", numbers);
            string escapeCharacters = @"hello world    WORLD";
            char letter = name[1];

            /*
            person.Introduce();
            person1.Introduce();
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(numbers[0] + numbers[1]);
            Console.WriteLine(names[1]);
            */
            Console.WriteLine(name);
            Console.WriteLine(list);
            Console.WriteLine(letter);
            Console.WriteLine(escapeCharacters);
        }
    }
}
