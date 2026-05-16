
class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string>
        {
            "What was the best part of your day?",
            "Who was your favorite person you talked to today?",
            "What did you learn today?",
            "What is something that you are grateful for?",
            "What can you improve on for tomorrow?"
        };

        Journal journal = new Journal();
        Random random = new Random();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\n=== Journal Menu ===");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = prompts[random.Next(prompts.Count)];
                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();
                journal.AddEntry(new Entry(prompt, response, date));
                Console.WriteLine("Entry added.");
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save to: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load from: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice != "5")
            {
                Console.WriteLine("Invalid option, try again.");
            }
        }
    }
}
