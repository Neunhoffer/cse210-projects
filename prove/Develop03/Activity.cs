class Activity
{
    private string _nameEN;
    private string _descriptionEN;
    protected int _durationEN;

    public Activity(string nameEN, string descriptionEN)
    {
        _nameEN = nameEN;
        _descriptionEN = descriptionEN;
    }

    public void StartMessage()
    {
        Console.WriteLine($"Hello please relax and prepare to begin the {_nameEN}. {_descriptionEN}");
        Console.Write($"Please enter the amount of time you would like to do The {_nameEN} for: ");
        _durationEN = int.Parse(Console.ReadLine());
        Console.WriteLine("Get Ready");
        Pause(5);
        Console.WriteLine();
    }
    public void EndMessage()
    {
        Console.WriteLine($"You have reached the end of the mindfulness activity congratulations!");
        Pause(5);
        Console.WriteLine($"You have completed The {_nameEN}, which you did for {_durationEN} seconds!");
        Pause(5);
    }
    public void Pause(int secondsEN)
    {
        for (int iEN = 0; iEN < secondsEN; iEN++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }
    public void Countdown(int secondsEN)
    {
        for (int iEN = secondsEN; iEN > 0; iEN--)
        {
            Console.Write(iEN);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
