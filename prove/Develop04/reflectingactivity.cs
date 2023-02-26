public class ReflectingActivity : Activity {
    private string[] _reflectionPrompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private string[] _reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private List<int> _remainingQuestions = new List<int>();
    public ReflectingActivity() : base("Reflecting activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") {
        for (int i = 0; i < _reflectionQuestions.Length; i++) {
            _remainingQuestions.Add(i);
        }
    }
    public void PrintPrompt() {
        Random randomNumber = new Random();
        int randomIndex = randomNumber.Next(0, _reflectionPrompts.Length);
        Console.WriteLine(_reflectionPrompts[randomIndex]);
        Console.WriteLine("When you have something in mind, press enter to continue.");
        while (Console.ReadLine() != "") {}
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("\nYou may begin in:  ");
        for (int i = 5; i> 0; i--) {
            Console.Write("\b" + i);
            Thread.Sleep(1000);
        }
        Console.Write("\n");
    }
    public void PrintQuestions() {
        Console.Clear();
        Random randomNumber = new Random();
        while (!IsActivityComplete()) {
            int randomIndex = randomNumber.Next(0, _remainingQuestions.Count);
            Console.WriteLine("> " + _reflectionQuestions[randomIndex]);
            _remainingQuestions.Remove(randomIndex);
            ShowSpinner(5);
        }
    }
}