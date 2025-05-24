public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, _words.Count());
            if (IsCompletlyhidden())
            {
                break;
            }
            else if (_words[randomNumber].IsHidden())
            {
                i--;
            }
            else
            {
                _words[randomNumber].Hide();
            }
        }
    }

    public string GetDisplayText()
    {
        string result = "";
        foreach (var item in _words)
        {
            if (item.IsHidden())
            {
                foreach (var letter in item.GetDisplaytext())
                {
                    result += "_";
                }
            }
            else
            {
                result += item.GetDisplaytext();
            }
            result += " ";
        }
        return result;
    }

    public bool IsCompletlyhidden()
    {
        return _words.All(w => w.IsHidden());
    }
}