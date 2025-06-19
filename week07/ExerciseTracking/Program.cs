/*
Author: Esteban Rubén Mangas Calva
W07 Assignment: Excercise Tracking Program
Programming with classes (abstraction, encapsulation, inheritance and polymorphism)
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        List<Activity> activities = new List<Activity>();
        RunningActivity runningActivity = new RunningActivity("19 Jun 2025", 25, 5);
        activities.Add(runningActivity);
        CyclingActivity cyclingActivity = new CyclingActivity("19 Jun 2025", 40, 25);
        activities.Add(cyclingActivity);
        SwimmingActivity swimmingActivity = new SwimmingActivity("19 Jun 2025", 30, 20);
        activities.Add(swimmingActivity);

        foreach (Activity activity in activities)
        {
            activity.DisplaySummary();
        }
    }
}