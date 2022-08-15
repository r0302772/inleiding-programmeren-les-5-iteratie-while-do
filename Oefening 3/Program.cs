using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Edit window title
            Console.Title = $"Exercise 3 - {DateTime.Now.ToLongDateString()} or {DateTime.Now.ToShortDateString()} - " +
                            $"{DateTime.Now.ToLongTimeString()} or {DateTime.Now.ToShortTimeString()}";

            //Edit screencolors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            //Reset console
            Console.Clear();

            //Declare variables
            int length, width;
            string input, symbol1, symbol2, teamquestion = "Of which team would you like to print the scarf (***** = stop)? ";

            do
            {
                Console.Write(teamquestion);
                input = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(input) || input.Length < 5);

            while (input != "*****")
            {
                string title = $"Supporterscraf {input}";
                Console.WriteLine($"\n{title}");
                Console.WriteLine(new string('*', title.Length));

                do
                {
                    Console.Write("Choose symbol 1: ");
                    input = Console.ReadLine();

                } while (string.IsNullOrWhiteSpace(input) || input.Length > 1);

                symbol1 = input;

                do
                {
                    Console.Write("Choose symbol 2: ");
                    input = Console.ReadLine();

                } while (string.IsNullOrWhiteSpace(input) || input.Length > 1);

                symbol2 = input;

                do
                {
                    Console.Write("How long does the scarf has to be (min. 4)? ");
                    input = Console.ReadLine();

                } while (!int.TryParse(input, out length) || length < 4);

                do
                {
                    Console.Write("How wide does the scarf has to be (min. 3)? ");
                    input = Console.ReadLine();

                } while (!int.TryParse(input, out width) || width < (length / 2) || width < 3);

                Console.WriteLine();

                for (int i = length; i > 0; i--)
                {
                    for (int i2 = width; i2 > 0; i2--)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(symbol1);
                        }
                        else
                        {
                            Console.Write(symbol2);
                        }
                    }

                    Console.WriteLine();
                }

                do
                {
                    Console.Write($"\n{teamquestion}");
                    input = Console.ReadLine();

                } while (string.IsNullOrWhiteSpace(input) || input.Length < 5);
            }

            Console.WriteLine("\nPress enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
