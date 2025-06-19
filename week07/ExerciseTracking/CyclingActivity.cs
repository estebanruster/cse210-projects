public class CyclingActivity : Activity
{
    //unique private member variables
    private double _speed;

    //Constructor calling base constructor
    public CyclingActivity(string date, double lenghtM, double speed) : base(date, lenghtM)
    {
        _speed = speed;
    }

    //Override methods
    public override double Distance()
    {
        return _speed / 60 * GetLenght();
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        return 60 / _speed;
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} Cycling ({GetLenght()} min)- Distance {Distance()} km, Speed {Speed()} kph, Pace {Pace()} min per km");
    }
}