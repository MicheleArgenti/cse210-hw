public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _point;

    public Goal(string shortName, string description, string point)
    {
        _shortName = shortName;
        _description = description;
        _point = point;
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetPoints()
    {
        return _point;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetDetailString();

    public abstract string GetStringRepresentation();

}