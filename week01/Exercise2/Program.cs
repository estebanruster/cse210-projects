using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? (type a number): ");
        int grade = int.Parse(Console.ReadLine());

        string letterGrade;

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is {letterGrade}.");

        if (letterGrade == "A" || letterGrade == "B" || letterGrade == "C")
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else if (letterGrade == "D" || letterGrade == "F")
        {
            Console.WriteLine("Sorry, you did not pass. Try again, you surley will pass the next time.");
        }
    }
}