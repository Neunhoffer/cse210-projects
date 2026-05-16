public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries yet.");
            return;
        }
        foreach (Entry entry in _entries)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine(entry.GetDisplayText());
        }
        Console.WriteLine("----------------------------");
    }

    public void SaveToFile(string filename)
    {
        List<string> lines = new List<string>();
        foreach (Entry entry in _entries)
        {
            lines.Add(entry.GetSaveText());
        }
        File.WriteAllLines(filename, lines);
        Console.WriteLine("Journal saved.");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            _entries.Add(Entry.FromSaveText(line));
        }
        Console.WriteLine("Journal loaded.");
    }
}
