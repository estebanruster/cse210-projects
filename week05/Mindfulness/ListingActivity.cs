//Creating ListingActivity class as a derived class of Activity
public class ListingActivity : Activity
{
    //Member variables unique to this class
    private int _count;
    private List<string> _prompts = new List<string>();
    private List<string> _userList = new List<string>();

    //Constructor that sets the value of the member variables
    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _time = 30;
    }

    //Methods to get/display a random prompt from the list, to get the
    //list the user is creating and to run the activity
    public void DisplayRandomPrompt()
    {

    }
    public List<string> GetListFromUser()
    {
        return _userList;
    }
}