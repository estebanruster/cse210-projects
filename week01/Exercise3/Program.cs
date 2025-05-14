using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        //Random class instance created
        Random randomGenerator = new Random();
        //Instance used to get the next integer between 1 to 100
        int magicNumber = randomGenerator.Next(1, 101);
        int guess;
        int guesses = 0;

        Console.WriteLine("Guess the magic number between 1 to 100!");

        do
        {
            Console.Write("What is your guess? (Type a number): ");
            guess = int.Parse(Console.ReadLine());
            guesses++;

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else if (guess == magicNumber)
            {
                Console.WriteLine("You guessed the magic number!");
                Console.WriteLine($"Number of guesses: {guesses}");
            }
        } while (guess != magicNumber);
    }
}