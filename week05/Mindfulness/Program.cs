/*
Author: Esteban Rubén Mangas Calva
W05 Project: Mindfulness Program
Inheritance principle
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
        //Menu for the mindfulnes program
        //Activity activity = new Activity();
        string menu;
        do
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activty");
            Console.WriteLine("3. Reflecting Activity");
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
                //Console.WriteLine("Breathing");
                //activity.ShowCountDown();
            }
            else if (menu == "2")
            {
                Console.Clear();
                Console.WriteLine("Listing");
                //activity.ShowSpinner();
            }
            else if (menu == "3")
            {
                Console.Clear();
                Console.WriteLine("Reflecting");
                //activity.ShowCountDown();
                //activity.ShowSpinner();
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