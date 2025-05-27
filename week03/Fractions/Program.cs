using System;
/*
Author: Esteban Rubén Mangas Calva
W03 Learning activity: Encapsulation
*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        //Testing Fraction constructors
        Fraction one = new Fraction();
        Fraction wholeNumber = new Fraction(7);
        Fraction newFraction = new Fraction(7, 9);

        /*
        Testing Getters and Setters
        Console.WriteLine($"{one.GetTop()}/{one.GetBottom()}");
        Console.WriteLine($"{wholeNumber.GetTop()}/{wholeNumber.GetBottom()}");
        Console.WriteLine($"{newFraction.GetTop()}/{newFraction.GetBottom()}");
        one.SetTop(8);
        one.SetBottom(5);
        Console.WriteLine($"{one.GetTop()}/{one.GetBottom()}");
        */

        //testing methods
        Console.WriteLine(one.GetFractionString());
        Console.WriteLine(one.GetDecimalValue());
        Console.WriteLine(wholeNumber.GetFractionString());
        Console.WriteLine(wholeNumber.GetDecimalValue());
        Console.WriteLine(newFraction.GetFractionString());
        Console.WriteLine(newFraction.GetDecimalValue());
    }
}