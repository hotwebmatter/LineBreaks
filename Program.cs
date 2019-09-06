/**
 * ######################################################
 * ##    Programming Assignment #6                     ##
 * ##    Developer: Matthew Obert                      ##
 * ##    Date Submitted: September 06 2019             ##
 * ##    Purpose: Demo \n escape sequence.             ##
 * ######################################################
 */

using System;
using static System.Console;

namespace LineBreaks
{

    class Program
    {
        static void WriteMenu(string output)
        {
            Clear();
            WriteLine("Choose an option:");
            WriteLine("1 = Full sentence on one line");
            WriteLine("2 = Comma separated clauses on new lines");
            WriteLine("3 = Each word on a new line\n");
            WriteLine("To exit, press 0 (zero) key.\n\n");
            WriteLine(output);
        }
        static void Main(string[] args)
        {
            string input;
            string message = "";
            int choice = 0;
            while (0 == 0)
            {
                WriteMenu(message);
                input = ReadLine();
                while (!int.TryParse(input, out choice))
                {
                    message = "Invalid input.\nPlease choose a number between 1 and 3.";
                    WriteMenu(message);
                    input = ReadLine();
                }
                /* TODO: Generalize algorithm as follows ...
                 *       Accept a string as input from the user
                 *       Iterate through all characters in string
                 *       Option 1 prints entire string on one line
                 *       Option 2 adds a newline after each comma
                 *       Option 3 adds a newline after each space
                 */
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;
                    case 1:
                        message = "Output #1:\n";
                        message += "Laugh often, Dream big, Reach for the stars!";
                        WriteMenu(message);
                        break;
                    case 2:
                        message = "Output #2:\n";
                        message += "Laugh often,\nDream big,\nReach for the stars!";
                        WriteMenu(message);
                        break;
                    case 3:
                        message = "Output #2:\n";
                        message += "Laugh\noften,\nDream\nbig,\nReach\nfor\nthe\nstars!";
                        WriteMenu(message);
                        break;
                    default:
                        message = "Please choose a number between 1 and 3 next time.";
                        WriteMenu(message);
                        break;
                }
            }
        }
    }
}
