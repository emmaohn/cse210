using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        // add job 1
        var job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // add job 2
        var job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // add resume
        var resume1 = new Resume();
        resume1._name = "Emma Johnson";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        // display resume with jobs
        resume1.DisplayResume();
    }
}