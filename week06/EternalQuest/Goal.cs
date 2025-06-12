public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _point;

    public Goal(string shortName, string description, string point)
    {
        _shortName = shortName;
        _description = description;
        _point = point;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetDetailString();

    public abstract string GetStringRepresentation();

}