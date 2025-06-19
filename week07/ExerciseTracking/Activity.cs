public abstract class Activity
{
    //private member variables to be inherit
    private string _date;
    private double _lenghtM;

    //Base Constructor
    public Activity(string date, double lenghtM)
    {
        _date = date;
        _lenghtM = lenghtM;
    }

    //Getters for the private member variables
    public string GetDate()
    {
        return _date;
    }
    public double GetLenght()
    {
        return _lenghtM;
    }

    //Methods to display/calculate for Distance, Speed, Pace and
    //DisplaySummary
    public abstract double Distance();

    public abstract double Speed();

    public abstract double Pace();
    
    public abstract void DisplaySummary();
}