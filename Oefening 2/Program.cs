using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_2
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
            Console.Title = $"Exercise 2 - {DateTime.Now.ToLongDateString()} or {DateTime.Now.ToShortDateString()} - " +
                            $"{DateTime.Now.ToLongTimeString()} or {DateTime.Now.ToShortTimeString()}";

            //Declare variables
            string title = "Request general information", lastname, firstname, input, magazine, message;
            string hobbySummary = "\n\t1. Handicrafts (knitting, crocheting, ...)" +
                                  "\n\t2. Making clothing" +
                                  "\n\t3. Decorating the interior" +
                                  "\n\t4. Playing football" +
                                  "\n\t5. Riding a bike" +
                                  "\n\t6. Photography" +
                                  "\n\t7. Running" +
                                  "\n\t8. Nothing";

            int hobby;

            Console.WriteLine($"\t{title}");
            Console.WriteLine($"\t{new string('*', title.Length)}");

            do
            {
                Console.Write("\tWhat's your last name: ");
                lastname = Console.ReadLine().ToUpper();

            } while (string.IsNullOrWhiteSpace(lastname));

            do
            {
                Console.Write("\tWhat's your first name: ");
                firstname = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(firstname));

            do
            {
                //Reset console
                Console.Clear();

                Console.WriteLine(hobbySummary);

                Console.Write($"\n\t{firstname} {lastname}, what hobby do you practice? ");
                input = Console.ReadLine();

            } while (!int.TryParse(input, out hobby));

            switch (hobby)
            {
                case 1:
                    magazine = "Anna";
                    break;
                case 2:
                    magazine = "Cutie";
                    break;
                case 3:
                    magazine = "VtLiving";
                    break;
                case 4:
                    magazine = "Football International";
                    break;
                case 5:
                    magazine = "Hiking & Cycling";
                    break;
                case 6:
                    magazine = "Zoom NL";
                    break;
                case 7:
                    magazine = "Runners";
                    break;
                default:
                    magazine = "";
                    break;
            }

            //Results
            if (magazine != "")
            {
                message = "We suggest as magazine: \"" + magazine + "\".";

                Console.WriteLine();
                //Set backgroundcolor to yellow
                Console.BackgroundColor = ConsoleColor.Yellow;

                Console.WriteLine($"\t{new string(' ', message.Length)}\n\t{new string(' ', message.Length)}");
                Console.WriteLine($"\t{message}");
                Console.WriteLine($"\t{new string(' ', message.Length)}\n\t{new string(' ', message.Length)}");

                //Set backgroundcolor back to white
                Console.BackgroundColor = ConsoleColor.White;
            }

            Console.WriteLine("\n\tPress enter to continue...");

            Console.ReadLine();
            //The program shuts down after the user presses enter
        }
    }
}
