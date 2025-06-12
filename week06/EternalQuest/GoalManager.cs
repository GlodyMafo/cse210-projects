using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;

    public void Start()
    {
        while (true)
        {
            Console.WriteLine($"\nScore: {_score}");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                case "6": return;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Choose goal type: 1. Simple  2. Eternal  3. Checklist");
        string type = Console.ReadLine();
        Console.Write("Name: "); string name = Console.ReadLine();
        Console.Write("Description: "); string desc = Console.ReadLine();
        Console.Write("Points: "); int points = int.Parse(Console.ReadLine());

        Goal goal = type switch
        {
            "1" => new SimpleGoal(name, desc, points),
            "2" => new EternalGoal(name, desc, points),
            "3" => CreateChecklistGoal(name, desc, points),
            _ => null
        };

        if (goal != null) _goals.Add(goal);
    }

    private ChecklistGoal CreateChecklistGoal(string name, string desc, int points)
    {
        Console.Write("Target count: "); int target = int.Parse(Console.ReadLine());
        Console.Write("Bonus points: "); int bonus = int.Parse(Console.ReadLine());
        return new ChecklistGoal(name, desc, points, target, bonus);
    }

    public void ListGoalDetails()
    {
        int index = 1;
        foreach (var goal in _goals)
        {
            string status = goal.IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{index++}. {status} {goal.GetDetailsString()}");
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Select goal to record: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            if (_goals[index] is ChecklistGoal cg && cg.IsComplete())
                _score += cg.IsComplete() ? cg._bonus + cg._points : cg._points;
            else
                _score += _goals[index] is SimpleGoal sg && sg.IsComplete() ? sg._points : _goals[index]._points;
        }
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
    }

    public void SaveGoals()
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();
        using StreamWriter writer = new(filename);
        writer.WriteLine(_score);
        foreach (var goal in _goals)
            writer.WriteLine(goal.GetStringRepresentation());
        Console.WriteLine("Saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("Filename: ");
        string filename = Console.ReadLine();
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            switch (type)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])) { _isComplete = bool.Parse(parts[4]) });
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[4]))
                    {
                        _amountCompleted = int.Parse(parts[6])
                    });
                    break;
            }
        }
        Console.WriteLine("Loaded successfully.");
    }
}
