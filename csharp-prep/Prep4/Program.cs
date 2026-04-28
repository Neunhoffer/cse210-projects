using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum = 0;
        int usernumber = 0;
        int max = 0;

        do
        {
            Console.WriteLine("Enter a list of numbers, (type 0 when finished)");
            Console.Write("Enter a number: ");
            usernumber = int.Parse(Console.ReadLine());

            if (usernumber != 0)
            {
                numbers.Add(usernumber);
            }

        } while (usernumber != 0);

        foreach (int number in numbers)
        {
            sum += number;
        }

        int count = numbers.Count;
        float average =((float)sum)/count;

        foreach (int number in numbers)
        {
            if (max < number)
            {
                max = number;
            }
        }

        Console.WriteLine($"The sum of your numbers is: {sum}");
        Console.WriteLine($"The average of your numbers is: {average}");
        Console.WriteLine($"The Largest number amoung your numbers is: {max}");
    }
}