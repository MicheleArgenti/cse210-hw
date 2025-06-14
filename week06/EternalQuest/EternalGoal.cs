public class EternalGoal : Goal
{

    public EternalGoal(string shortName, string description, string point) : base(shortName, description, point) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulation! You have earned {_point}");
    }
    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal;{_shortName};{_description};{_point}";
    }
    public override string GetDetailString()
    {
        return $"[ ] {_shortName} ({_description})";
    }

}