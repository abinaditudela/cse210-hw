using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.GetEntry());
        }
    }

    public void SaveJournal(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        foreach (Entry entry in _entries)
        {
            outputFile.WriteLine(entry.GetEntry());
        }
    }

    public void LoadJournal(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            // Assumes data is saved in a specific format, e.g., Date, Prompt, and Response separated by newline
            // Splitting or reconstructing the entry would happen here
            string[] parts = line.Split(",");
            string firstName = parts[0];
            string lastName = parts[1];
        }
    }
}
