public class Entry
{
    private string _prompt;
    private string _response;
    private string _date;

    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    public string GetDisplayText()
    {
        return $"Date: {_date}\nPrompt: {_prompt}\nResponse: {_response}";
    }

    public string GetSaveText()
    {
        return $"{_date}|{_prompt}|{_response}";
    }

    public static Entry FromSaveText(string line)
    {
        string[] parts = line.Split('|');
        return new Entry(parts[1], parts[2], parts[0]);
    }
}
