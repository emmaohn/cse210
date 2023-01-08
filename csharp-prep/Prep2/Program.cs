using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade percentage? ");
        string userValue = Console.ReadLine();
        int grade = int.Parse(userValue);
        
        string letter;
        string message;

        if (grade >= 90) {
            letter = "A";
        } else if (grade >= 80) {
            letter = "B";
        } else if (grade >= 70) {
            letter = "C";
        } else if (grade >= 60) {
            letter = "D";
        } else {
            letter = "F";
        }
        Console.WriteLine($"{letter}");

        if (grade >= 70) {
            message = "Great Job!";
        } else {
            message = "Keep focusing!";
        }
        Console.WriteLine($"{message}");
    }
}