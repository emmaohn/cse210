using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,11);
        Console.WriteLine(number);
        int guess = 0;
        string message;

        while (guess != number) {
            Console.WriteLine("Take a guess: ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);
            if (guess > number) {
                message = "Lower";
            } else if (guess < number) {
                message = "Higher";
            } else {
                message = "Nice job!";
            }
            Console.WriteLine(message);
        }
    }
}