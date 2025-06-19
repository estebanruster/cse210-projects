public class RunningActivity : Activity
{
    //unique private member variables
    private double _distance;

    //Constructor calling base constructor
    public RunningActivity(string date, double lenghtM, double distance) : base(date, lenghtM)
    {
        _distance = distance;
    }

    //Override methods
    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        return _distance / GetLenght() * 60;
    }

    public override double Pace()
    {
        return GetLenght() / _distance;
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} Running ({GetLenght()} min)- Distance {Distance()} km, Speed {Speed()} kph, Pace {Pace()} min per km");
    }
}