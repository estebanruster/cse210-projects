/*
Author: Esteban Rubén Mangas Calva
W03 Learning activity: Encapsulation
Fraction class; encapsulation principle practice
*/
public class Fraction
{
    //Creating private member variables
    private int _top;
    private int _bottom;

    //Creating constructors. One with no parameters initializing in 1/1,
    //other for the numerator with denominator initialized in 1 and other
    //with two paarameters for the whole fraction
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //Creating getters and setters for top and bottom numbers
    //Top getter and setter
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    //Bottom getter and setter
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
}