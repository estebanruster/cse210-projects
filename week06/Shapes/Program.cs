/*
Author: Esteban Rubén Mangas Calva
W06 Learning activity: Polymorphism
.
Polymorphism is build upon the other three principles of programming with
classes: abstraction, encapsulation and inheritance. This program task is
to calculate the area of Shapes(Square, Rectangle and Circle). Each Shape
sould contain its _color and their dimensions; as well to calculate the
area with an aproriate behavior for each derived Shape class
(polimorphism principle).
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        //Creating a list to hold shapes (List<Shape>)
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("Orange", 7);
        shapes.Add(square);
        Rectangle rectangle = new Rectangle("purple", 13, 5);
        shapes.Add(rectangle);
        Circle circle = new Circle("turquoise", 4);
        shapes.Add(circle);

        //Iterating through the list and displaying color and area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine();
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}u\xB2");
        }
    }
}