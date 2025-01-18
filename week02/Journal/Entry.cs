using System;

public class Entry
{
    string _date;
    string _promptText;
    string _entryText;

    public Entry(string promptText, string entryText)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }

    public override string ToString()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }

    public static Entry FromString(string entryData)
    {
        string[] parts = entryData.Split('|');
        if (parts.Length == 3)
        {
            return new Entry(parts[1], parts[2]) { _date = parts[0] };
        }
        throw new Exception("Invalid entry format.");
    }
}
