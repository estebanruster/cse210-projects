public class Rectangle : Shape
{
    //Rectangle exclusive member variables to calculate the area
    private double _lenght;
    private double _width;

    //Creating constructor calling base constructor to avoid system errors
    //Adding as well their own member variables to the constructor
    public Rectangle(string color, double lenght, double width) : base(color)
    {
        _lenght = lenght;
        _width = width;
    }

    //Creating override class method GetArea to avoid system errors
    public override double GetArea()
    {
        return _lenght * _width;
    }
}