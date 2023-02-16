using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");
        string userInput = "";

        Scripture[] scriptures = {
            new Scripture(
                new Reference("Proverbs", 3, 5, 6), 
                "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths."
            ),
            new Scripture(
                new Reference("John", 3, 16), 
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
            )
        };

        Random randomGenerator = new Random();
        Scripture scripture = scriptures[randomGenerator.Next(0,scriptures.Length)];
        scripture.Print();

        while (userInput != "quit" && scripture.CheckAllBlank() == false) {
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish");
            userInput = Console.ReadLine();
            scripture.Blank(3);
            scripture.Print();
            // Console.Clear();
        }
        Console.WriteLine("\nThanks for playing!");
    }
}