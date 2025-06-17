public abstract class Activity
{

    private string _date;
    protected double _minutes;

    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_minutes} min): Distance {Distance()} km, Speed: {Speed()} kph, Pace: {Pace()} min per km";
    }

    public abstract double Distance();

    public abstract double Speed();

    public abstract double Pace();

}