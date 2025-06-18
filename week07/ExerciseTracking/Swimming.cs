public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int lengthInMinutes, int laps) : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double meters = _laps * 50;
        return meters / 1000.0;
    }
    public override double GetSpeed() => (GetDistance() / GetLength()) * 60;
    public override double GetPace() => GetLength() / GetDistance();
}