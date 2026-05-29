class Reference
{
    private string _bookEN;
    private int _chapterEN;
    private int _startVerseEN;
    private int _endVerseEN;

    public Reference(string bookEN, int chapterEN, int verseEN)
    {
        _bookEN = bookEN;
        _chapterEN = chapterEN;
        _startVerseEN = verseEN;
        _endVerseEN = verseEN;
    }

    public Reference(string bookEN, int chapterEN, int startVerseEN, int endVerseEN)
    {
        _bookEN = bookEN;
        _chapterEN = chapterEN;
        _startVerseEN = startVerseEN;
        _endVerseEN = endVerseEN;
    }

    public string GetDisplayText()
    {
        if (_startVerseEN == _endVerseEN)
            return $"{_bookEN} {_chapterEN}:{_startVerseEN}";
        return $"{_bookEN} {_chapterEN}:{_startVerseEN}-{_endVerseEN}";
    }
}
