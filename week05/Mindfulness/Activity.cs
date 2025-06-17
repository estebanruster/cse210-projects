public class Activity
{
    //Member variables common to all the activities: name, description
    //and time
    //Trying to make member variables protected in order to use them in
    //the derived classes
    protected string _name;
    protected string _description;
    protected int _time;

    //Methods for displaying starting and ending messages; and for
    //waiting animations and time
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _time = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner();
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_time} seconds of the {_name} Activity.");
        ShowSpinner();
        Console.Clear();
    }
    public void ShowSpinner()
    {
        List<string> animationStrings =
        [
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\",
        ];

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(10);

        int i = 0;

        while (DateTime.Now < futureTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}