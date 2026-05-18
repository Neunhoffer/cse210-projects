using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        Random random = new Random();

        for (int i = 0; i < 20; i++)
        {
            int top = random.Next(1, 20);
            int bottom = random.Next(1, 20);
            f.SetTop(top);
            f.SetBottom(bottom);
            Console.WriteLine($"Fraction {i + 1}: string: {f.GetFractionString()} Number: {f.GetDecimalValue()}");
        }

        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(5, 10);

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f1.GetBottom());
        Console.WriteLine(f1.GetTop());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f2.GetBottom());
        Console.WriteLine(f2.GetTop());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine(f3.GetBottom());
        Console.WriteLine(f3.GetTop());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine(f3.GetBottom());
        Console.WriteLine(f3.GetTop());
    }
}