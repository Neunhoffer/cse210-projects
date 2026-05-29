// Exceeds requirements by:
// 1. Maintaining a library of multiple scriptures and selecting one at random each run.
// 2. Stretch challenge: only words that are not yet hidden are candidates for hiding (no wasted turns).

using System.Collections.Generic;

class Program
{
    static void Main(string[] argsEN)
    {
        List<Scripture> libraryEN =
        [
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"),
            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths"),
            new Scripture(new Reference("2 Nephi", 2, 25),
                "Adam fell that men might be and men are that they might have joy"),
            new Scripture(new Reference("Mosiah", 2, 17),
                "When ye are in the service of your fellow beings ye are only in the service of your God"),
            new Scripture(new Reference("Joshua", 1, 9),
                "Be strong and of a good courage be not afraid neither be thou dismayed for the Lord thy God is with thee whithersoever thou goest"),
        ];

        Random rngEN = new();
        Scripture scriptureEN = libraryEN[rngEN.Next(libraryEN.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scriptureEN.GetDisplayText());
            Console.WriteLine();

            if (scriptureEN.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Great work!");
                break;
            }

            Console.Write("Press Enter to hide more words or type 'quit' to exit: ");
            string inputEN = Console.ReadLine() ?? "";

            if (string.Equals(inputEN.Trim(), "quit", StringComparison.OrdinalIgnoreCase))
                break;

            scriptureEN.HideRandomWords(3);
        }
    }
}
