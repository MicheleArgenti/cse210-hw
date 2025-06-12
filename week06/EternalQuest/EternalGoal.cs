public class EternalGoal : Goal
{

    public EternalGoal(string shortName, string description, string point) : base(shortName, description, point) { }

    public override string GetDetailString()
    {
        throw new NotImplementedException();
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
}