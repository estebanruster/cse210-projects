using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();

        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int squared = SquareNumber(userNumber);

        DisplayResult(userName, squared);

        Console.WriteLine("End of Program.");
    }

    //DisplayWelcome message function.
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    //PromptUserName and return the user name as a string.
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    //PromptUserNumber and return the user favorite number as an int.
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }

    //SquareNumber accepts an int as a parameter and returns that number squared as an int.
    static int SquareNumber(int userNumber)
    {
        int squared = userNumber * userNumber;
        return squared;
    }

    //DisplayResult accepts the user's name and the squared number and displays them.
    static void DisplayResult(string userName, int squared)
    {
        Console.WriteLine($"{userName}, the square of your number is {squared}");
    }
}