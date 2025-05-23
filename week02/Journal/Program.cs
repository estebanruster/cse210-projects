/*
Author: Esteban Rubén Mangas Calva
W02 Project: Journal Program
Program Main function code
*/
using System;

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

        //Getting the random prompt


        //Testing Entry class member variables and method
        Entry entry = new Entry();
        //Getting the random prompt
        entry._prompt = prompts.GetRandomPrompt();
        //Later, implemente DateTime to get the date from the computer
        entry._dateText = "5/21/2025";
        Console.WriteLine(entry._prompt);
        entry._entry = Console.ReadLine();

        entry.DisplayEntry();
    }
}