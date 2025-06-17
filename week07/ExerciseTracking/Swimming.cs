public class Swimming : Activity
{

    private double _laps;

    public Swimming(double laps, string date, double minutes) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double Distance()
    {
        return _laps * 50 / 1000;
    }

    public override double Pace()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double Speed()
    {
        return Distance() / _minutes * 60;
    }

}