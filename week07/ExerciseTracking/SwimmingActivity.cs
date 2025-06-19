public class SwimmingActivity : Activity
{
    //unique private member variables
    private double _laps;

    //Constructor calling base constructor
    public SwimmingActivity(string date, double lenghtM, double laps) : base(date, lenghtM)
    {
        _laps = laps;
    }

    //Override methods
    public override double Distance()
    {
        return _laps * 50 / 1000;
    }

    public override double Speed()
    {
        return Distance() / GetLenght() * 60;
    }

    public override double Pace()
    {
        return 60 / Speed();
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{GetDate()} Swimming ({GetLenght()} min)- Distance {Distance()} km, Speed {Speed()} kph, Pace {Pace()} min per km");
    }
}