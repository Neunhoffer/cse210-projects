using System.Diagnostics;

class Reflection : Activity
{
    private Random randomEN = new Random();

    private List<string> _promptsEN = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questionsEN = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public Reflection() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }
    public void ReflectionExercise()
    {
        StartMessage();

        int indexEN = randomEN.Next(_promptsEN.Count);
        string chosenEN = _promptsEN[indexEN];

        Console.WriteLine(chosenEN);

        DateTime endTimeEN = DateTime.Now.AddSeconds(_durationEN);
        while (DateTime.Now < endTimeEN)
        {
            int index1EN = randomEN.Next(_questionsEN.Count);
            string chosen1EN = _questionsEN[index1EN];
            Console.WriteLine(chosen1EN);
            Pause(7);
        }

        EndMessage();
    }
}
