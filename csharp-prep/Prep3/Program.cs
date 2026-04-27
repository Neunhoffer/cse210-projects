using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int magicnumber = randomGenerator.Next(1,20);

        int guess = 0;

        while (guess != magicnumber)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            
            if (guess > magicnumber)
            {
                Console.WriteLine("Nice try but your number is a little bit too high");
            }
            else if (guess < magicnumber)
            {
                Console.WriteLine("Nice try but your number is a little bit too low");
            }
            else if (guess == magicnumber)
            {
                Console.WriteLine("CONGRATULATIONS you guessed the number");
            }
        }
    }
}