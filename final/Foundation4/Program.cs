using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");
        List<Activity> activities = new List<Activity>();

        DateTime currentTime =  DateTime.Now;
        string currentDate =  currentTime.ToShortDateString();

        activities.Add(new Run(currentDate, 30, 3));
        activities.Add(new Bike(currentDate, 20, 7));
        activities.Add(new Swim(currentDate, 25, 8));

        foreach (Activity activity in activities) {
            activity.GetSummary();
        }
    }
}