class Word(string textEN)
{
    private string _textEN = textEN;
    private bool _isHiddenEN;

    public bool IsHidden => _isHiddenEN;

    public void Hide() => _isHiddenEN = true;

    public string GetDisplayText() => _isHiddenEN ? new string('_', _textEN.Length) : _textEN;
}
