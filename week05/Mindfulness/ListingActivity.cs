//Creating ListingActivity class as a derived class of Activity
public class ListingActivity : Activity
{
    //Member variables unique to this class
    private List<string> _prompts = new List<string>();
    private List<string> _userList = new List<string>();

    //Constructor that sets the value of the member variables
    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _time = 30;
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    //Methods to get/display a random prompt from the list, to get the
    //list the user is creating and to run the activity
    public void Run()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        DisplayRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown();
        Console.WriteLine();
        GetListFromUser();
        Console.WriteLine($"You listed {_userList.Count} items!");
    }
    public void DisplayRandomPrompt()
    {
        //Random class instance created
        Random randomGenerator = new Random();
        //Instance used to get the next integer between 0 to 3
        int randomIndex = randomGenerator.Next(0, 5);
        Console.WriteLine($"---{_prompts[randomIndex]}---");
    }
    public void GetListFromUser()
    {
        _userList.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);
        string userResponse;
        while (DateTime.Now < futureTime)
        {
            Console.Write(">");
            userResponse = Console.ReadLine();
            _userList.Add(userResponse);
        }
    }
}