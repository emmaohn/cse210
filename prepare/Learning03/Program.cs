using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");

        // initialize new fraction instances
        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction(5);
        Fraction frac3 = new Fraction(3, 4);
        Fraction frac4 = new Fraction(1, 3);

        // print fraction one
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());

        // print fraction two
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDecimalValue());

        // print fraction three
        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetDecimalValue());

        // print fraction four
        Console.WriteLine(frac4.GetFractionString());
        Console.WriteLine(frac4.GetDecimalValue());
    }
}