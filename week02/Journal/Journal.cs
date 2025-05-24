/*
Author: Esteban Rubén Mangas Calva
W02 Project: Journal Program
Journal class code
*/
using System.IO;
public class Journal
{
    //Creating member variable _entries
    public List<Entry> _entries = new List<Entry>();

    //Creating the methods to AddEntry in the list, DisplayAll the journal
    //SaveToFile and LoadFromFile the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputfile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputfile.WriteLine($"Date: {entry._dateText} - Prompt: {entry._prompt}");
                outputfile.WriteLine(entry._entry);
                outputfile.WriteLine();
            }
        }
    }

    public void LoadFromFile(string file)
    {

    }
}