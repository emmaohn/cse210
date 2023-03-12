using System;

class Program
{
    static void Main(string[] args)
    {
        Goal goal = new Goal;
        string userInput = "0";
        // Console.WriteLine("Hello Develop05 World!");
        while (userInput != "6") {
            Console.WriteLine("Menu options:\n  1. Create new goal\n  2. List Goals\n  3. Save goals\n  4. Load Goals\n  5. Record Event\n  6. Quit\nSelect a choice from the menu:");
            userInput = Console.ReadLine();
            if (userInput == "1") {
                // Put all of this in goal?
                // string goalType = "0";
                // Console.WriteLine("The types of goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\nWhat kind of goal would you like to create?");
                // 
                // if (goalType == "1") {
                  
                // } else if (goalType == "2") {

                // } else if (goalType == "3") {

                // } else {
                //     Console.WriteLine("Please enter a valid menu option");
                // }
            } else if (userInput == "2") {
                // call display here
            } else if (userInput == "3") {
                // 
            } else if (userInput == "4") {

            } else if (userInput == "5") {

            } else if (userInput == "6") {
                Console.Clear();
                Console.WriteLine("Goodbye!");
                break;
            } else {
                Console.WriteLine("Please enter a valid menu option");
            }
        }
    }
}