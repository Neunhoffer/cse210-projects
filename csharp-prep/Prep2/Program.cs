using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello please type your grade percentage in here: ");
        string letter = "";
        string grade = Console.ReadLine();
        float number = float.Parse(grade);
        if (number >= 70.0)
        {
            Console.WriteLine("Congratulations you passed the class!!!");
        }
        else
        {
            Console.WriteLine("Sorry you failed the class:( Retake it next year and you will pass for sure!!!");
        }
        if (number >= 90.0)
        {
            letter = "A";
        }
        else if (number >= 80.0)
        {
            letter = "B";
        }
        else if (number >= 70.0)
        {
            letter = "C";
        }
        else if (number >= 60.0)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"You completed the class with {letter} as your final grade.");
    }
    
}