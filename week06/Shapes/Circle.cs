public class Circle : Shape
{
    //Circle exclusive member variables to calculate the area
    private double _radius;

    //Creating constructor calling base constructor to avoid system errors
    //Adding as well their own member variables to the constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    //Creating override class method GetArea to avoid system errors
    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}