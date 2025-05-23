public class Entry
{
    public string _date = "";

    public string _promptText = "";

    public string _entryText = "";

    public void Display()
    {
        Console.WriteLine($"{_date}: {_promptText} - {_entryText}");
    }

    public override string ToString()
    {
        return $"{_date}~|~{_promptText}~|~{_entryText}";
    }

    public static Entry FromString(string line)
    {
        string[] parts = line.Split("~|~");
        return new Entry
        {
            _date = parts[0],
            _promptText = parts[1],
            _entryText = parts[2]
        };
    }
}