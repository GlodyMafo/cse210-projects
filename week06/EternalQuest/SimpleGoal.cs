public class SimpleGoal : Goal
{
    public bool _isComplete = false;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You earned {_points} points.");
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}
