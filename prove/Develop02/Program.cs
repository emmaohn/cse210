using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        
        string userChoice = "0";
        Journal journal = new Journal();
        Promptgenerator promptgen = new Promptgenerator();

        Console.WriteLine("Welcome to the journal program!");
        
        while (userChoice != "5") {
            // show option menu
            Console.WriteLine("Please select one of the following choices\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do?");
            userChoice = Console.ReadLine();

            if (userChoice == "1") {
                // new prompt every time
                // get prompt and pass it
                string prompt = promptgen.GetPrompt();
                Console.WriteLine(prompt);
                // get current date and pass it
                DateTime currentTime =  DateTime.Now;
                string currentDate =  currentTime.ToShortDateString();
                // get the user entry and pass it
                string userInput = Console.ReadLine();
                // create an entry and store it locally
                journal.CreateEntry(currentDate, prompt, userInput);

            } else if (userChoice == "2") {
                // display!!!!!
                journal.DisplayEntries();

            } else if (userChoice == "3") {
                // load file
                Console.WriteLine("What file would you like to load?");
                string fileName = Console.ReadLine();
                journal.LoadJournal(fileName);

            } else if (userChoice == "4") {
                // save to a file, overwrite if file already exists
                Console.WriteLine("Where would you like to store this journal?");
                string fileName = Console.ReadLine();
                journal.SaveJournal(fileName);

            } else if (userChoice == "5") {
                // bye bye code
                break;

            } else {
                // if there is no valid input, run the while again
                Console.WriteLine("Please enter a valid menu number");
            }
        }
    }
}