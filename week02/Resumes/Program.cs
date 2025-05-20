using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2024;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Back end developer";
        job2._startYear = 2022;
        job2._endYear = 2025;

        //Display company
        Console.WriteLine(job1._company);
        Console.WriteLine(job2._company);

        //calling DisplayJobDetails method of the Job class
        //job1.DisplayJobDetails();
        //job2.DisplayJobDetails();

        /*
        Resume resume = new Resume();
        resume._name = "Ricardo Guerrero";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        //Console.WriteLine(resume._jobs[0]._company);
        //calling DisplayResume method of the Resume class
        resume.DisplayResume();*/
    }
}