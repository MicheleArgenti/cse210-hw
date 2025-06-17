public class Running : Activity
{

    private double _distance;

    public Running(double distance, string date, double minutes) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }

    public override double Pace()
    {
        return _minutes / _distance;
    }

    public override double Speed()
    {
        return _distance / _minutes * 60;
    }

}