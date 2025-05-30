using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        bool menuCondition = true;
        Reference reference = new Reference("DyC", 58, 42, 43);
        Scripture scripture = new Scripture(reference, "Behold, he who has repented of his sins, the same is forgiven, and I, the Lord, remember them no more. By this ye may know if a man repenteth of his sins —behold, he will confess them and forsake them.");
        Console.WriteLine(scripture.GetDisplayText());
        do
        {
            Console.Write("Do you want to continue? (type 'quit' to exit or press enter to continue): ");
            string wantContinue = Console.ReadLine();
            if (wantContinue == "")
            {
                menuCondition = true;
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
            }
            else if (wantContinue == "quit")
            {
                menuCondition = false;
            }
            else
            {
                menuCondition = true;
                Console.WriteLine("Invalid input. Try again");
            }
        } while (menuCondition == true);
    }
}