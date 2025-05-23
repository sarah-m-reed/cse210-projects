using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }

        Console.WriteLine($"Journal saved to: {file}");
    }

    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                Entry entry = Entry.FromString(line);
                _entries.Add(entry);
            }

            Console.WriteLine($"Journal loaded from: {file}");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}