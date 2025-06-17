/*
Author: Esteban Rubén Mangas Calva
W05 Project: Mindfulness Program
Inheritance principle

To exceed the core requirements; in the ReflectingActivity in the
DisplayQuestions method I made that It will not give a repeated question
until it has displayed each question at least once.
*/

using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.Clear();
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();
        //Menu for the mindfulnes program
        //Activity activity = new Activity();
        string menu;
        do
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activty");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            menu = Console.ReadLine();

            //If statements to manage the options of the menu
            if (menu == "1")
            {
                Console.Clear();
                breathingActivity.DisplayStartingMessage();
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
            }
            else if (menu == "2")
            {
                Console.Clear();
                reflectingActivity.DisplayStartingMessage();
                reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();
            }
            else if (menu == "3")
            {
                Console.Clear();
                listingActivity.DisplayStartingMessage();
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
            }
            else if (menu == "4")
            {
                Console.WriteLine("Exiting program. See you later");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input. Choose a number from the menu.");
            }
        } while (menu != "4");
    }
}