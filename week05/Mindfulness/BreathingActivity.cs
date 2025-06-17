//Creating BreathingActivity class as a derived class of Activity
public class BreathingActivity : Activity
{
    //This class doesn't have member variables

    //Constructor that sets the value of the member variables
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _time = 30;
    }

    //Run method that contains the coding of the activity working
    public void Run()
    {
        //Console.Clear();
        //Console.WriteLine("Get ready...");
        //ShowSpinner();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);
        while (DateTime.Now < futureTime)
        {
            Console.WriteLine();
            Console.Write("Breath in....");
            ShowCountDown();
            Console.WriteLine();
            Console.Write("Breath out...");
            ShowCountDown();
            Console.WriteLine();
        }
        //Console.WriteLine();
        //Console.WriteLine("Well done!!");
    }
}