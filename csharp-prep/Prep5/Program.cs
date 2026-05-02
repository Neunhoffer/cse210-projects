using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

class Program
{
        static void Main(string[] args)
        {
            DisplayWelcome();
            string username = PromptUserName();
            int favnumber = PromptUserNumber();
            PromptUserBirthYear(out int birthday);
            int squared = SquareNumber(favnumber);
            DisplayResult(birthday, username, squared);
        }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.WriteLine("Please enter your Username here: ");
            string username = Console.ReadLine();
            return username;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            int favnumber = int.Parse(Console.ReadLine());
            return favnumber;
        }
        static void PromptUserBirthYear(out int birthday)
        {
            Console.WriteLine("Please enter Birthday Year: ");
            birthday = int.Parse(Console.ReadLine());
        }
        static int SquareNumber(int number)
        {
            return number * number;
        }
        static void DisplayResult(int birthday, string username, int number)
        {
            int Age = 2026 - birthday;
            Console.WriteLine($"{username}, the square root of your number is {number}");
            Console.WriteLine($"{username}, you will turn {Age} this year.");
        }
}