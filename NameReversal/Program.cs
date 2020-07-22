using System;
using System.Collections.Generic;

namespace NameReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string[] nameInput = Console.ReadLine().Split(' ');

            Array.Reverse(nameInput);
            string reversedName = string.Join(' ', nameInput);

            Console.WriteLine("The reverse of your name is: {0}", nameInput);
        }
    }
}
