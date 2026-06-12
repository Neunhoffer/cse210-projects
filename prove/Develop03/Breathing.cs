using System.Diagnostics;

class Breathing : Activity
{
    public Breathing() : base("Breathing Activity", "This Activity will help you relax by breathing in and out")
    {
    }
    public void BreathingExercise()
    {
        StartMessage();

        DateTime endTimeEN = DateTime.Now.AddSeconds(_durationEN);
        while (DateTime.Now < endTimeEN)
        {
            Console.WriteLine("Breathe in");
            Pause(4);
            Console.WriteLine("Breathe out");
            Pause(4);
        }

        EndMessage();
    }
}
