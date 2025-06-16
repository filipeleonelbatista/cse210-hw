public class EternalGoal : Goal
{
    public EternalGoal(string title, string description, int points) : base(title, description, points) { }

    public override int RecordEvent()
    {
        return _points;
    }

    public override string GetStatusString()
    {
        return $"[ ] {_title} ({_description})";
    }

    public override string SaveString()
    {
        return $"EternalGoal|{_title}|{_description}|{_points}";
    }
}
