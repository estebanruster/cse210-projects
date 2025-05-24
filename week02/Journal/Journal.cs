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
        //Foreach loop to displayEntry every Entry object in list
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string file)
    {
        //Creating StreamWriter object with using code to create file and write in it
        using (StreamWriter outputfile = new StreamWriter(file))
        {
            //Foreach loop to access each member variable of each Entry object in the list
            foreach (Entry entry in _entries)
            {
                //Writing in the output file the strings of each member variable of Entry separated by |
                outputfile.WriteLine($"{entry._prompt}|{entry._entry}|{entry._dateText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        //using System.IO.ReadAllLines() function to open the file, read all the lines and close it
        string[] lines = File.ReadAllLines(file);
        //foreach loop to iterate through all the lines of the file saved in the lines list of strings
        foreach (string line in lines)
        {
            //creating another list of parts of each line divided by | to save each value in a member variable of the Entry class
            string[] parts = line.Split("|");

            //Entry class member variables and method saving load file strings
            Entry entry = new Entry();
            entry._prompt = parts[0];
            entry._entry = parts[1];
            entry._dateText = parts[2];
            //Adding new entry to _entries list
            AddEntry(entry);
        }
    }
}