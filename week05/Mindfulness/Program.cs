class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflecting Activity");
        Console.WriteLine("3. Listing Activity");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());

        Activity activity = null;

        switch (choice)
        {
            case "1":
                activity = new BreathingActivity(duration);
                break;
            case "2":
                activity = new ReflectingActivity(duration);
                break;
            case "3":
                activity = new ListingActivity(duration);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        activity.Run();

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
