using System.ComponentModel.DataAnnotations;

public class Comment
{
    private string _owner;
    private string _text;

    public Comment(string owner, string text)
    {
        _owner = owner;
        _text = text;
    }

    public string DisplayComment()
    {
        return $"{_owner}: {_text}";
    }
}