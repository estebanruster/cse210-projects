/*
Author: Esteban Rubén Mangas Calva
W02 Project: Journal Program
Journal class code
*/
public class Journal
{
    //Creating member variables _fileName and _entries
    public string _fileName = "";
    public List<Entry> _entries = new List<Entry>();

    //Creating the methods to AddEntry in the list, DisplayAll the journal
    //SaveToFile and LoadFromFile the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        //Console.WriteLine($"Name: {_name}");
        //Console.WriteLine("Jobs:");

        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    {

    }
}