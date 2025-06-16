public class SimpleGoal : Goal
{
    public SimpleGoal(string title, string description, int points) : base(title, description, points) { }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override string SaveString()
    {
        return $"SimpleGoal|{_title}|{_description}|{_points}|{_isComplete}";
    }
}
