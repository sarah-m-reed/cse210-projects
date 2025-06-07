public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(6);
            Console.WriteLine();

            elapsed += 10;
        }

        DisplayEndingMessage();
    }
}