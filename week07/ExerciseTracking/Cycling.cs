public class Cycling : Activity
{

    private double _speed;

    public Cycling(double speed, string date, double minutes) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double Distance()
    {
        return _speed * _minutes / 60;
    }

    public override double Pace()
    {
        return 60 / _speed;
    }

    public override double Speed()
    {
        return _speed;
    }

}