using System;
using Develop05;

class Program
{
    private List<Goal> goals;
    private int score;

    public Program()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void CreateGoal(string goalType, string name, int[] args)
    {
        Goal newGoal = null;
        switch (goalType)
        {
            case "Simple":
                newGoal = new SimpleGoal(name, args[0]);
                break;
            case "Eternal":
                newGoal = new EternalGoal(name, args[0]);
                break;
            case "CheckList":
                newGoal = new CheckList(name, args[0], args[1], args[2]);
                break;
            default:
                Console.WriteLine("Invalid Goal Type");
                break;
        }

        if (newGoal != null)
        {
            goals.Add(newGoal);
        }
    }

    public void RecordEvent(int goalindex)
    {
        if (goalindex >= 0 && goalindex < goals.Count)
        {
            Goal goal = goals[goalindex];
            int eventReward = goal.RecordEvent();
            score += eventReward;
        }

        else
        {
            Console.WriteLine("Goal Index out of range");
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0 ; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].DisplayProgress()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {score}");
    }

    public void SaveProgress(string filename)
    {
        using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                file.WriteLine($"{goal.Name}, {goal.Completed}, {(goal is CheckList ? ((CheckList)goal).timesCompleted : 0)}");
            }

            file.WriteLine($"Score: {score}");
        }
    }

    public void LoadProgress(string filename)
    {
        goals.Clear();
        score = 0;

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            if (parts[0] == "Score")
            {
                score = int.Parse(parts[1]);
            }

            else
            {
                if (parts.Length >= 3)
                {
                    int[] goalArgs = new int [3];
                    for (int i = 1; i > 4; i++)
                    {
                        goalArgs[i - 1] = int.Parse(parts[i]);
                    }

                    if (goalArgs[2] > 0)
                    {
                        goals.Add(new CheckList(parts[0], goalArgs[0], goalArgs[1], goalArgs[2]));
                    }

                    else if (goalArgs[0] > 0)
                    {
                        goals.Add(new SimpleGoal(parts[0], goalArgs[0]));
                    }

                    else
                    {
                        goals.Add(new EternalGoal(parts[0], goalArgs[0]));
                    }
                }
            }
        }
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.CreateGoal("simple", "Run a marathon", new int[] { 1000 });
        program.CreateGoal("eternal", "Read scriptures", new int[] { 100 });
        program.CreateGoal("checklist", "Attend the temple", new int[] { 50, 10, 500 });

        program.RecordEvent(0); // Running a marathon
        program.RecordEvent(1); // Reading scriptures
        program.RecordEvent(2); // Attending the temple

        program.DisplayGoals();
        program.DisplayScore();

        program.SaveProgress("progress.txt");
    }
}

    