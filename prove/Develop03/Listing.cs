using System.Diagnostics;

class Listing : Activity
{
    private Random randomEN = new Random();
    private List<string> _answersEN = new List<string>()
    {
    };
    private List<string> _sentencesEN = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public Listing() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }
    public void ListingExercise()
    {
        StartMessage();

        int indexEN = randomEN.Next(_sentencesEN.Count);
        string chosenEN = _sentencesEN[indexEN];

        Console.WriteLine(chosenEN);

        int countEN = 0;
        DateTime endTimeEN = DateTime.Now.AddSeconds(_durationEN);
        while (DateTime.Now < endTimeEN)
        {
            Console.WriteLine("Enter Here: ");
            _answersEN.Add(Console.ReadLine());
            countEN++;
        }
        Console.WriteLine($"You listed {countEN} items!");
        Console.WriteLine($"Here is the items you entered: {string.Join(", ", _answersEN)}");
        EndMessage();
    }
}
