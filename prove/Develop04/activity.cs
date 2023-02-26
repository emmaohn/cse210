public class Activity {
    private string[] _spinIndicator = {"|", "/", "-","\\"};
    private int _currentChar;
    private string _title;
    private string _description;
    private int _length;
    private DateTime _timerEnd;
    public Activity(string title, string description) {
        _title = title;
        _description = description;
    }
    public void ShowSpinner(int duration) {
        _currentChar = 0;
        DateTime current = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now <= current) {
            Console.Write("\b" + _spinIndicator[_currentChar % 4]);
            Thread.Sleep(300);
            _currentChar++;
        }
        Console.Write("\b ");
    }
    public void PrintIntro() {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_title} \n\n{_description}\n");
    }
    public void StartTimer() {
        _timerEnd = DateTime.Now.AddSeconds(_length);
    }
    public bool IsActivityComplete() {
       return DateTime.Now >= _timerEnd;
    }
    public void LengthPrompt() {
        Console.WriteLine($"How long, in seconds, would you like for your session? ");
        _length = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Get ready...\n");
    }
    public void PrintOutro() {
        Console.WriteLine($"\n\nWell done!");
        ShowSpinner(5);
        Console.WriteLine($"You completed {_length} seconds of {_title}");
        Thread.Sleep(5000);
    }
}