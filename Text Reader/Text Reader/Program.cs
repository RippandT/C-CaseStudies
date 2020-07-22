using System;
using System.IO;

namespace Text_Reader
{
    class Program
    {
        /* Function for file selection */
        static int ItemChoice(string[] items, string optionName)
        {
            int choice = 0;

            while (true)
            {
                Console.WriteLine(optionName + "\n");

                for (int i = 0; i < items.Length; i++)
                {
                    if (i == choice)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("--> " + items[i]);
                        Console.ResetColor();
                    }
                    else
                    { Console.WriteLine("    " + items[i]); }
                }

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        --choice;
                        if (choice < 0)
                        { choice = items.Length - 1; }
                        break;

                    case ConsoleKey.DownArrow:
                        ++choice;
                        if (choice == items.Length)
                        { choice = 0; }
                        break;

                    case ConsoleKey.Enter:
                        return choice;

                    default:
                        break;
                }

                Console.Clear();
            }
        }

        /* Main program */
        static void Main(string[] args)
        {
            Console.CursorVisible = false; // Turns off the cursor
            string[] textFiles = Directory.GetFiles(".", "*.txt"); // Gets text files
            string welcome = "Text File Word Counter! \nSelect text file \n(choose with UpArrow and DownArrow, select with Enter)";

            if (textFiles.Length != 0)
            {
                //Reads the selected text file, and count with an array
                var text = System.IO.File.ReadAllText(textFiles[ItemChoice(textFiles, welcome)]);
                var counter = text.Split(' ');
                Console.WriteLine("\nWord count: {0}", counter.Length);
            }
            else
            {
                //When there is no text file inside the program's directory
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: No .txt files detected. Place files in the directory of the program");
                Console.ResetColor();
            }


            Console.WriteLine("\n...Press any key to exit...");
            Console.ReadKey();
        }
    }
}
