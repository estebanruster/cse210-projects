//code for the Resume class
public class Resume
{
    //member variables
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    //method (member function) to display Resume job list
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayJob();
        }

    }
}