public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, string point) : base(shortName, description, point) { }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }

    public override string GetDetailString()
    {
        throw new NotImplementedException();
    }

}