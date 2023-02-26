public class ListingActivity : Activity {
    private string[] _listingPrompts = {   
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<int> _remainingQuestions = new List<int>();
    int _totalAnswers = 0;
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") {}
    public void PrintPrompt() {
        Random randomNumber = new Random();
        int randomIndex = randomNumber.Next(0, _listingPrompts.Length);
        Console.WriteLine(_listingPrompts[randomIndex]);
    }
    public void PromptUser() {
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("\nYou may begin in:  ");
        for (int i = 5; i> 0; i--) {
            Console.Write("\b" + i);
            Thread.Sleep(1000);
        }
        Console.WriteLine("\b \n");
        StartTimer();
        while (!IsActivityComplete()) {
            Console.Write("> ");
            Console.ReadLine();
            _totalAnswers++;
        }
        Console.WriteLine($"You listed {_totalAnswers} items");
    }
}