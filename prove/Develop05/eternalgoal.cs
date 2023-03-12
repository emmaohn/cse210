public class EternalGoal : Goal {
    public EternalGoal(string goalName, string goalDescription, int points) : base (goalName, goalDescription, points) {
        
    }
    public override void CreateGoal() {
        // name
        Console.WriteLine("What is the name of your goal? ");
        string name = Console.ReadLine();
        // description
        Console.WriteLine("What is a short description of your goal? ");
        string description = Console.ReadLine();
        // points
        Console.WriteLine("What is the amount of points associated with each completion of this goal? ");
        string userInputPoints = Console.ReadLine();
        int points = int.Parse(userInputPoints);
        // new eternal goal
        Goal goal = new EternalGoal(name, description, points);
    }
    // public override string GetSaveData() {
    //     return $"{_goalName}|{_goalDescription}|{points}";
    // }
}