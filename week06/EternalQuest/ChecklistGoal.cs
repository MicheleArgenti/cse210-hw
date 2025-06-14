public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(int target, int bonus, string shortName, string description, string point) : base(shortName, description, point)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override void RecordEvent()
    {
        if (IsComplete())
        {
            Console.WriteLine($"Congratulation! You have earned {_point + _bonus}");
        }
        else
        {
            Console.WriteLine($"Congratulation! You have earned {_point}");
        }
        _amountCompleted += 1;
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
            return true;
        else
            return false;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal;{_shortName};{_description};{_point};{_bonus};{_target};{_amountCompleted}";
    }

    public override string GetDetailString()
    {
        if (_amountCompleted == _target)
            return $"[X] {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target}";
        else
            return $"[ ] {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target}";
    }

}