public class Square : Shape
{
    //Square exclusive member variables to calculate the area
    private double _side;
    //Creating constructor calling base constructor to avoid system errors
    //Adding as well their own member variables to the constructor
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    //Creating override class method GetArea to avoid system errors
    public override double GetArea()
    {
        return Math.Pow(_side, 2);
    }
}