//Base abstract class. This class is not meant to be instantiated
public abstract class Shape
{
    //_color private member variable
    private string _color;

    //Base constructor
    public Shape(string color)
    {
        _color = color;
    }

    //Abstract class method GetArea()
    public abstract double GetArea();

    //GetColor method to return _color as a string
    public string GetColor()
    {
        return _color;
    }
}