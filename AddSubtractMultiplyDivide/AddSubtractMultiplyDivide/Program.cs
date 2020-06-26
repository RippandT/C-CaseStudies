using System;

/*
 * - Week 2 of our classes
 * - Introduction to variables (and to error handling during the activity)
 */

namespace Week2_Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first integer: ");
            string firstInt = Console.ReadLine();
            float firstNum = float.Parse(firstInt);
            try
            {
                firstNum = float.Parse(firstInt);
            }
            catch (Exception)
            {
                Console.WriteLine("Error: input is not a number");
            }

            Console.WriteLine("Enter the second integer: ");
            string secondInt = Console.ReadLine();
            float secondNum = float.Parse(secondInt);
            try
            {
                secondNum = float.Parse(secondInt);
            }
            catch (Exception)
            {
                Console.WriteLine("Error: input is not a number");
            }

            Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, firstNum + secondNum);
            Console.WriteLine("{0} - {1} = {2}", firstNum, secondNum, firstNum - secondNum);
            Console.WriteLine("{0} * {1} = {2}", firstNum, secondNum, firstNum * secondNum);
            Console.WriteLine("{0} / {1} = {2}", firstNum, secondNum, firstNum / secondNum);
        }
    }
}
