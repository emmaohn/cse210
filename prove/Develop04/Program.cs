using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "0";
        // Console.WriteLine("Hello Develop04 World!");
        Console.WriteLine("Welcome to the mindfulness Program");
        while (userInput != "4") {
            Console.Clear();
            Console.WriteLine("Menu Options:\n1. Breathing Activity\n2. Reflecting Activity\n3. Listing Activity\n4. Quit\nSelect a choice from the menu");
            userInput = Console.ReadLine();
            if (userInput == "1") {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.PrintIntro();
                breathingActivity.LengthPrompt();
                breathingActivity.ShowSpinner(5);
                breathingActivity.StartTimer();
                breathingActivity.BreatheTimer();
                breathingActivity.PrintOutro();
            } else if (userInput == "2") {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.PrintIntro();
                reflectingActivity.LengthPrompt();
                reflectingActivity.ShowSpinner(5);
                reflectingActivity.PrintPrompt();
                reflectingActivity.StartTimer();
                reflectingActivity.PrintQuestions();
                reflectingActivity.PrintOutro();
            } else if (userInput == "3") {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.PrintIntro();
                listingActivity.LengthPrompt();
                listingActivity.ShowSpinner(5);
                listingActivity.PrintPrompt();
                listingActivity.PromptUser();
                listingActivity.PrintOutro();
            } else if (userInput == "4") {
                Console.WriteLine("Goodbye!");
                break;
            } else {
                Console.WriteLine("Please enter a valid menu option");
            }
        }
    }
}