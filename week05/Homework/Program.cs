/*
Author: Esteban Rubén Mangas Calva
W05 Learning Activity: Inheritance
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Console.WriteLine();

        //Testing base class
        //Assignment assignment = new Assignment("Esteban", "Inheritance");
        //Console.WriteLine(assignment.GetSummary());

        //Testing MathAssignment class
        MathAssignment mathAssignment = new MathAssignment("Esteban Mangas", "Fractions", "8.5", "4-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();

        //Testing WritingAssignment class
        WritingAssignment writingAssignment = new WritingAssignment("Sara Calderón", "Doctrine of Christ", "How to develop faith in Jesus Christ");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}