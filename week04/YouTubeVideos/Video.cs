using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _videoLength;
    private List<Comment> _comments;

    public Video(string title, string author, int videoLength)
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public string DisplayVideo()
    {
        return $"Author: {_author}\nTitle: {_title}\nVideo Length: {_videoLength} seconds";
    }

    public string DisplayComment()
    {
        string result = "";
        foreach (Comment comment in _comments)
        {
            result += $"{comment.DisplayComment()}\n";
        }
        return result;
    }

    public string GetNumberComments()
    {
        return $"{_comments.Count()}";
    }
}