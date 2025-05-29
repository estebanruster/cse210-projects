public class Reference
{
    //Member variables for reference (one for each component in the scripture
    //reference). Member variables made private.
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //Constructors for the reference. One for a single verse scripture
    //and one for verse range scripture
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    //Class method that get the string to display of the reference
    public string GetDisplayText()
    {
        string displayText;
        if (_endVerse != 0)
        {
            displayText = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            displayText = $"{_book} {_chapter}:{_verse}";
        }
        return displayText;
    }
}