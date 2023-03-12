public abstract class Goal {
    private List<Goal> _goalList = new List<Goal>();
    private string _goalName;
    private string _goalDescription;
    private int _points;
    public Goal(string goalName, string goalDescription, int points) {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _points = points;
    }
    public abstract void CreateGoal();
    // public abstract void RecordGoal();
    public void CompleteGoal() {

    }
    // OVERRIDE
    // public void CreateEntry(string _date, string _prompt, string _userInput) {
    //     Goal goal = new Goal(_goalName, _goalDescription);
    //     _goalList.Add(goal);
    // }
    // public abstract string GetSaveData();
    // public override string GetSaveData() {
    //     return $"{_goalName}|{_goalDescription}|{points}";
    // }
    public void Print() {
        Console.WriteLine($"{_goalName}: {_goalDescription}");
    }
    public void DisplayEntries() {
        // if there are no entries, nothing will print
        if (_goalList.Count() == 0) {
            Console.WriteLine("No current journal entries");
        // display current entries
        } else {
            foreach (Goal goal in _goalList) {
                goal.Print();
            }
        }
    }
    // public void LoadJournal(string fileName) {
    //     // _journal = "myFile.txt";
    //     string[] lines = System.IO.File.ReadAllLines(fileName);

    //     foreach (string line in lines) {
    //         string[] parts = line.Split("|");

    //         // 0 date, 1 prompt, 2 userInput
    //         _goalList.Add(new Goal(parts[0],parts[1]));
    //     }
    // }
    // public void SaveJournal(string fileName) {
    //     using (StreamWriter outputFile = new StreamWriter(fileName)) {
    //         // store journal entries
    //         foreach (Goal goal in _goalList) {
    //             outputFile.WriteLine(goal.GetSaveData());
    //         }
    //     }
    // }
}