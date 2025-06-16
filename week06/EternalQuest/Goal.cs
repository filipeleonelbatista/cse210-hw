public abstract class Goal
{
    protected string _title;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public string Title => _title;
    public string Description => _description;
    public int Points => _points;
    public bool IsComplete => _isComplete;

    public abstract int RecordEvent();

    public virtual string GetStatusString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_title} ({_description})";
    }

    public abstract string SaveString();
}
