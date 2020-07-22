using System;

namespace Whitespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //User inputs his/her name
            Console.Write("Enter your name: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string name = Console.ReadLine();
            Console.ResetColor();

            //User inputs his/her age
            Console.Write("Enter your age: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string age = Console.ReadLine();
            Console.ResetColor();

            //Stores the input into an array separated by spaces
            var arrName = name.Split(' ');
            var arrAge = age.Split(' ');

            //With the implication of the array lenght, we can count how many whitespaces there are
            //Subtraction of 2 excludes the last word, because it implies that there is no whitespace after the last word
            //Without the subtraction, the whitespace count would overshoot by two
            int whitespaces = arrName.Length + arrAge.Length - 2;

            //Outputs the whitespace count
            Console.Write("Number of whitespaces: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(whitespaces);
            Console.ResetColor();

            Console.Write("\n...Press any key to exit...");
            Console.ReadKey();
        }
    }
}
