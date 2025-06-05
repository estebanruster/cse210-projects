public class Video
{
    //Creating 4 memeber variables for class Video to store title,
    //author, lenght (in seconds) and a list of comments type Comment
    public string _title;
    public string _author;
    public string _lengthS;
    public List<Comment> _comments = new List<Comment>();

    //NumberComments() method get the lenght of the list and return it
    //as an int
    public int NumberComments()
    {
        return _comments.Count;
    }

    //DisplayVideo() method takes DisplayComment() method from Comment
    //and display Video info and its comments
    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title} | Author: {_author} | Length: {_lengthS} sec.");
        Console.WriteLine($"Number of comments: {NumberComments()}");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}