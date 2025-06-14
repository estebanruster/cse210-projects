//Creating BreathingActivity class as a derived class of Activity
public class BreathingActivity : Activity
{
    //This class doesn't have member variables

    //Constructor that sets the value of the member variables
    public BreathingActivity(int time)
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _time = time;
    }

    //Run method that contains the coding of the activity working
    public void Run()
    {
        
    }
}