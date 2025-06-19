public class EternalGoal : Goal
{
    //It has not unique member variables; only the ones it inherite

    //Constructor for the class; calling base constructor to avoid error
    //systems.
    public EternalGoal(string shortName, string description, string points) : base(shortName, description, points)
    {
    }
    
    //Override methods from the abstract ones
    public override int RecordEvent()
    {
        return int.Parse(GetPoints());
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetShortName()}|{GetDescription()}|{GetPoints()}";
    }
}