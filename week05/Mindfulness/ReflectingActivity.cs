public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };
    private Random _random = new Random();

    public ReflectingActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }
    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();

        Console.WriteLine("Now reflect on the following questions:");

        // I made it so that the same question won't repeat in the same session
        List<string> remainingQuestions = new List<string>(_questions);
        ShuffleList(remainingQuestions);

        int duration = GetDuration();
        int elapsed = 0;

        int questionIndex = 0;

        while (elapsed < duration && questionIndex < remainingQuestions.Count)
        {
            string question = remainingQuestions[questionIndex];
            DisplayQuestion(question);
            ShowSpinner(5);

            elapsed += 5;
            questionIndex++;
        }

        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
    public string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);
        return _questions[index];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
    }
    public void DisplayQuestion(string question)
    {
        Console.WriteLine();
        Console.WriteLine($"> {question}");
    }
    public void ShuffleList(List<string> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = _random.Next(n + 1);
            string value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}