using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    private const int V = 1;

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");

        int number = 1;
        int sum = 0;
        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        foreach (int listnumber in numbers)
        {
            sum = sum + listnumber;
        }
        Console.WriteLine($"The sum is: {sum}");

        double length = numbers.Count;
        double average = sum/length;
        //Console.WriteLine(length);
        Console.WriteLine($"The average is: {average}");

        int largest = 0;
        foreach (int listnumber in numbers)
        {
            if (listnumber > largest)
            {
                largest = listnumber;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}