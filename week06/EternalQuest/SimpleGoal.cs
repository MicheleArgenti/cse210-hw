public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, string point) : base(shortName, description, point)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulation! You have earned {_point}");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal;{_shortName};{_description};{_point};{_isComplete}";
    }

    public override string GetDetailString()
    {
        if (_isComplete)
            return $"[X] {_shortName} ({_description})";
        else
            return $"[ ] {_shortName} ({_description})";
    }

}