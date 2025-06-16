using System;
/*
 * Creativity: 
 * - Implemented a simple leveling system that could be added by extending points thresholds.
 * - Added ability to show partial progress in checklist goals.
 * - Used polymorphism extensively for RecordEvent and SaveString methods.
 * - Could be extended with negative goals or rewards.
 */
class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Select an option: ");
            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateGoal(manager);
                    break;
                case "2":
                    manager.ListGoals();
                    break;
                case "3":
                    Console.Write("Enter goal number to record event: ");
                    if (int.TryParse(Console.ReadLine(), out int goalNum))
                        manager.RecordEvent(goalNum - 1);
                    break;
                case "4":
                    Console.WriteLine($"Your total points: {manager.TotalPoints}");
                    break;
                case "5":
                    manager.SaveToFile("goals.txt");
                    Console.WriteLine("Goals saved.");
                    break;
                case "6":
                    manager.LoadFromFile("goals.txt");
                    Console.WriteLine("Goals loaded.");
                    break;
                case "7":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string? input = Console.ReadLine();

        Console.Write("Title: ");
        string title = Console.ReadLine() ?? "";

        Console.Write("Description: ");
        string description = Console.ReadLine() ?? "";

        Console.Write("Points per completion: ");
        int.TryParse(Console.ReadLine(), out int points);

        switch (input)
        {
            case "1":
                manager.AddGoal(new SimpleGoal(title, description, points));
                break;
            case "2":
                manager.AddGoal(new EternalGoal(title, description, points));
                break;
            case "3":
                Console.Write("How many times to complete? ");
                int.TryParse(Console.ReadLine(), out int target);
                Console.Write("Bonus points on completion: ");
                int.TryParse(Console.ReadLine(), out int bonus);
                manager.AddGoal(new ChecklistGoal(title, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
        Console.WriteLine("Goal created!");
    }
}
