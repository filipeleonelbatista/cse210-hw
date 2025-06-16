using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new();
    private int _totalPoints = 0;

    public int TotalPoints => _totalPoints;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ListGoals()
    {
        Console.WriteLine("Your Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatusString()}");
        }
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            int pointsEarned = _goals[goalIndex].RecordEvent();
            _totalPoints += pointsEarned;
            Console.WriteLine($"You earned {pointsEarned} points!");
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void SaveToFile(string filename)
    {
        using StreamWriter writer = new(filename);
        writer.WriteLine(_totalPoints);
        foreach (Goal goal in _goals)
        {
            writer.WriteLine(goal.SaveString());
        }
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("Save file not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();
        _totalPoints = 0;

        if (lines.Length > 0)
        {
            _totalPoints = int.Parse(lines[0]);
            for (int i = 1; i < lines.Length; i++)
            {
                Goal? goal = ParseGoal(lines[i]);
                if (goal != null)
                    _goals.Add(goal);
            }
        }
    }

    private Goal? ParseGoal(string line)
    {
        string[] parts = line.Split('|');
        string type = parts[0];
        try
        {
            switch (type)
            {
                case "SimpleGoal":
                    var simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    typeof(Goal).GetField("_isComplete", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                        .SetValue(simpleGoal, bool.Parse(parts[4]));
                    return simpleGoal;
                case "EternalGoal":
                    return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                case "ChecklistGoal":
                    var checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]));
                    typeof(ChecklistGoal).GetField("_currentCount", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                        .SetValue(checklistGoal, int.Parse(parts[4]));
                    typeof(Goal).GetField("_isComplete", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                        .SetValue(checklistGoal, bool.Parse(parts[7]));
                    return checklistGoal;
                default:
                    return null;
            }
        }
        catch
        {
            return null;
        }
    }
}
