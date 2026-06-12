using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {

        string ChoiceEN = "";

        while (ChoiceEN != "4")
        {
            Console.WriteLine("Hello this is the Mindfulness Program:)");
            Console.WriteLine("Choose a option:\n");
            Console.WriteLine("1.) Breathing Exercise\n2.) Reflection Exercise\n3.) Listing Exercise\n4.) Quit");
            Console.Write("\nYour Choice: ");
            ChoiceEN = Console.ReadLine();

            if (ChoiceEN == "1")
            {
                Breathing breathingEN = new Breathing();
                breathingEN.BreathingExercise();
            }
            else if (ChoiceEN == "2")
            {
                Reflection reflectionEN = new Reflection();
                reflectionEN.ReflectionExercise();
            }
            else if (ChoiceEN == "3")
            {
                Listing listingEN = new Listing();
                listingEN.ListingExercise();
            }
            else if (ChoiceEN == "4")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice please pick a choice 1-4");
            }
        }
    }
}
