/*
Author: Esteban Rubén Mangas Calva
W02 Project: Journal Program
Program Main function code
*/

//I show creativity in the menu if the user enters another character different from the numbers of 
//the options an else code display a invalid input message and the menu displays again.

using System;
using System.Diagnostics;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        //Instantiate PromptGenerator class to create a list with the prompts
        PromptGenerator prompts = new PromptGenerator();
        /*
        string prompt1 = "What was the strongest emotion I felt today and why?";
        prompts._prompts.Add(prompt1);
        string prompt2 = "If I had one thing I could do over today, what would it be?";
        prompts._prompts.Add(prompt2);
        string prompt3 = "What is one thing I could learn from today?";
        prompts._prompts.Add(prompt3);
        string prompt4 = "Who was the most interesting person I interacted with today and why?";
        prompts._prompts.Add(prompt4);
        string prompt5 = "For what are you grateful today and why?";
        prompts._prompts.Add(prompt5);
        string prompt6 = "What was the funniest thing that happened today?";
        prompts._prompts.Add(prompt6);
        */

        //Instatntiate Journal class to create a Journal Object to test AddEntry and Display all
        Journal journal = new Journal();

        string menuCondition;

        //Creating the menu
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Load Journal");
            Console.WriteLine("4. Save Journal");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            menuCondition = Console.ReadLine();

            //Write Entry code
            if (menuCondition == "1")
            {
                //Testing Entry class member variables and method
                Entry entry = new Entry();
                //Getting the random prompt
                entry._prompt = prompts.GetRandomPrompt();
                //Later, implemente DateTime to get the date from the computer
                DateTime currentTime = DateTime.Now;
                entry._dateText = currentTime.ToShortDateString();
                Console.WriteLine(entry._prompt);
                entry._entry = Console.ReadLine();
                //entry.DisplayEntry();
                journal.AddEntry(entry);
            }

            //Display Journal code
            else if (menuCondition == "2")
            {
                journal.DisplayAll();
            }

            //Load Journal code
            else if (menuCondition == "3")
            {
                Console.WriteLine("Please write the file name.");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }

            //Save Journal code
            else if (menuCondition == "4")
            {
                Console.WriteLine("Please write the file name.");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }

            //Quit
            else if (menuCondition == "5")
            {
                Console.WriteLine("See you later!");
            }

            //Exceptions
            else
            {
                Console.WriteLine("Invalid answer. Enter only the number of the option you want.");
            }
        } while (menuCondition != "5");
    }
}