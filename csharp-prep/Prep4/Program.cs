using System;

class Program
{
    
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        int number = 1;
        int sum = 0;
        int largest = 0;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0) {
            Console.WriteLine("Enter a number. ");
            string userInput = Console.ReadLine(); 
            number = int.Parse(userInput);
            numbers.Add(number);
            sum = sum + number;
        }

        foreach (int i in numbers) {
            if (i > largest) {
                largest = i;
            }
            // Console.WriteLine(i);
        }

        float average = ((float)sum) / (numbers.Count-1);

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
        
}