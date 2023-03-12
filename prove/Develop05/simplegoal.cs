public class SimpleGoal : Goal {
    public SimpleGoal(string goalName, string goalDescription, int points) : base (goalName, goalDescription, points) {

    }
    public override void CreateGoal() {
        // name
        Console.WriteLine("What is the name of your goal? ");
        string name = Console.ReadLine();
        // description
        Console.WriteLine("What is a short description of your goal? ");
        string description = Console.ReadLine();
        // points
        Console.WriteLine("What is the amount of points associated with this goal? ");
        string userInputPoints = Console.ReadLine();
        int points = int.Parse(userInputPoints);
        // new simple goal
        Goal goal = new SimpleGoal(name, description, points);
    }
    // public override string GetSaveData() {
    //     return $"{_goalName}|{_goalDescription}|{points}";
    // }
}