public class ChecklistGoal : Goal {
    private int _timesToComplete;
    private int _bonusPoints;
    public ChecklistGoal(string goalName, string goalDescription, int points, int timesToComplete, int bonusPoints) : base (goalName, goalDescription, points) {
        _timesToComplete = timesToComplete;
        _bonusPoints = bonusPoints;
    }
    public override void CreateGoal() {
        // name
        Console.WriteLine("What is the name of your goal? ");
        string name = Console.ReadLine();
        // description
        Console.WriteLine("What is a short description of your goal? ");
        string description = Console.ReadLine();
        // single completion points
        Console.WriteLine("What is the amount of points associated with each completion of this goal? ");
        string userInputPoints = Console.ReadLine();
        int points = int.Parse(userInputPoints);
        // times to complete NEW
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        string userInputTimesToComplete = Console.ReadLine();
        int timesToComplete = int.Parse(userInputTimesToComplete);
        // completion bonus NEW
        Console.WriteLine("What is the amount of points associated with each completion of this goal? ");
        string userInputBonusPoints = Console.ReadLine();
        int bonusPoints = int.Parse(userInputBonusPoints);
        Goal goal = new ChecklistGoal(name, description, points, timesToComplete, bonusPoints);
    }
    // public override string GetSaveData() {
    //     return $"{_goalName}|{_goalDescription}|{points}";
    // }
}