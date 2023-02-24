using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");
        Assignment assignment = new Assignment("jojo", "stuff and things");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Emma", "Nultiplication", "7.3", "8-19");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Levi", "European history", "Causes of world war two");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}