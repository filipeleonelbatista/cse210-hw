
public class BreathingActivity : Activity
{
    public BreathingActivity(int durationInSeconds) 
        : base("Breathing Activity",
               "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
               durationInSeconds)
    {
    }

    public override void Run()
    {
        Start();

        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.WriteLine("\nBreathe in...");
            Countdown(4); // pausa 4 segundos para inspirar

            Console.WriteLine("\nBreathe out...");
            Countdown(6); // pausa 6 segundos para expirar

            elapsed += 10;
        }

        End();
    }
}