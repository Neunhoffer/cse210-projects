using System.Collections.Generic;

class Scripture
{
    private Reference _referenceEN;
    private List<Word> _wordsEN;
    private Random _randomEN = new();

    public Scripture(Reference referenceEN, string textEN)
    {
        _referenceEN = referenceEN;
        _wordsEN = [];
        foreach (string wEN in textEN.Split(' '))
            _wordsEN.Add(new Word(wEN));
    }

    public bool IsCompletelyHidden() => _wordsEN.TrueForAll(wEN => wEN.IsHidden);

    public void HideRandomWords(int countEN)
    {
        List<Word> visibleEN = _wordsEN.FindAll(wEN => !wEN.IsHidden);
        for (int iEN = 0; iEN < countEN && visibleEN.Count > 0; iEN++)
        {
            int indexEN = _randomEN.Next(visibleEN.Count);
            visibleEN[indexEN].Hide();
            visibleEN.RemoveAt(indexEN);
        }
    }

    public string GetDisplayText()
    {
        List<string> partsEN = [];
        foreach (Word wEN in _wordsEN)
            partsEN.Add(wEN.GetDisplayText());
        return $"{_referenceEN.GetDisplayText()}\n{string.Join(" ", partsEN)}";
    }
}
