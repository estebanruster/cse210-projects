/*
Author: Esteban Rubén Mangas Calva
W06 Project: Eternal Quest Program
Polymorphism principle

To exceed the requirements I made that the goals acomplished (Simple and
Checklist) can not record again other event. Also the menu manage if the
user type other input non existant in the menu.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}