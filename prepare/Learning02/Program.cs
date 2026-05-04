using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._name = "Allison Rose";
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._name = "Larry Wheels";
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2020;
        job2._endYear = 2026;

        Resume resume1 = new Resume();
        resume1._name = "Allison Rose";
        
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}
