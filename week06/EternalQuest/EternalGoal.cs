public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override int RecordEvent()
    {
        return _points;
    }
    public override bool IsComplete() => false;
    public override string GetDetailsString()
    {
        return $"[\u221E] {_name} ({_description})";
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_name}|{_description}|{_points}";
    }
}