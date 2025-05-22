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

        //Testing Entry class member variables and method
        Entry entry = new Entry();
        //Prompt place-holder. Later get it from PromptGenerator class
        entry._prompt = "This is the prompt. Write something.";
        //Later, implemente DateTime to get the date from the computer
        entry._dateText = "5/21/2025";
        Console.WriteLine(entry._prompt);
        entry._entry = Console.ReadLine();

        entry.DisplayEntry();
    }
}