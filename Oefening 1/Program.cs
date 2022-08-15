using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Edit screencolors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            //Reset console
            Console.Clear();

            //Edit window title
            Console.Title = $"Exercise 1 {DateTime.Now.ToLongDateString()} or {DateTime.Now.ToShortDateString()} - " +
                            $"{DateTime.Now.ToLongTimeString()} or {DateTime.Now.ToShortTimeString()}";

            //Declare variables
            string input, friends = "";

            do
            {
                Console.Write("Do you have any friends? (\"Yes\" or \"No\") ");
                input = Console.ReadLine().ToLower();

            } while (input != "yes" && input != "no");


            while (input == "yes")
            {
                do
                {
                    Console.Write("\nEnter the first name of your friend: ");
                    input = Console.ReadLine();

                } while (string.IsNullOrWhiteSpace(input));

                friends += $"\n\t{input}";

                do
                {
                    Console.Write("\nDo you have any other friends? (\"Yes\" or \"No\") ");
                    input = Console.ReadLine().ToLower();

                } while (input != "yes" && input != "no");
            }

            if (friends == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\tI'm sorry you don't have any friends, maybe join a social website?");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nMy friends:");
                Console.WriteLine(friends);
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
