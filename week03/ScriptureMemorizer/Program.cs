using System;
using System.Runtime.InteropServices;
/*
Author: Esteban Rubén Mangas Calva
W03 Project: Scripture Memorizer
Encapsulation

To exceed the requirements I make the menu manage if the user types
anything different from quit or different from press enter.
Also, I code the scripture.HideRandomWords method to keep track of words
still shown, so it only hide words that were not previously hidden; and
all the words are hidden at random using a Random object randomGenerator.Next
*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        bool menuExit = false;
        Reference reference = new Reference("DyC", 58, 42, 43);
        Scripture scripture = new Scripture(reference, "Behold, he who has repented of his sins, the same is forgiven, and I, the Lord, remember them no more. By this ye may know if a man repenteth of his sins —behold, he will confess them and forsake them.");
        Console.WriteLine(scripture.GetDisplayText());
        do
        {
            Console.Write("Do you want to continue? (type 'quit' to exit or press enter to continue): ");
            string wantContinue = Console.ReadLine();
            if (wantContinue == "")
            {
                //menuExit = false;
                scripture.HideRandomWords();
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                menuExit = scripture.IsCompletelyHidden();
            }
            else if (wantContinue == "quit")
            {
                menuExit = true;
            }
            else
            {
                menuExit = false;
                Console.WriteLine("Invalid input. Try again");
            }
        } while (menuExit == false);
    }
}