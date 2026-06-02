using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Bob", "History");
        Console.WriteLine(assignment1.GetSummary());
        
        MathAssignment mathassignment1 = new MathAssignment("Doug", "Math", "Section 8.4", "Problems 10-20");
        Console.WriteLine(mathassignment1.GetHomeworkList());

        WritingAssignment writingassignment1 = new WritingAssignment("Fred","English" ,"The Adventures of Peabody");
        Console.WriteLine(writingassignment1.GetWritingInformation());
    }
}