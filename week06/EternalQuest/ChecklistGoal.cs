public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public int CurrentCount => _currentCount;
    public int TargetCount => _targetCount;
    public int BonusPoints => _bonusPoints;

    public ChecklistGoal(string title, string description, int points, int targetCount, int bonusPoints)
        : base(title, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _currentCount++;
            if (_currentCount >= _targetCount)
            {
                _isComplete = true;
                return _points + _bonusPoints;
            }
            return _points;
        }
        return 0;
    }

    public override string GetStatusString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_title} ({_description}) -- Completed {_currentCount}/{_targetCount}";
    }

    public override string SaveString()
    {
        return $"ChecklistGoal|{_title}|{_description}|{_points}|{_currentCount}|{_targetCount}|{_bonusPoints}|{_isComplete}";
    }
}
