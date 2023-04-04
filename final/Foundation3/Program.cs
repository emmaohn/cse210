using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");

        // title, description, date, time, address, speaker, capacity
        Lecture lecture = new Lecture("Birds of Indiana", "Levi William recounts his most interesting enounters with the birds of indiana", "03/30/2023", "11:00pm-12:00pm", new Address("3726 Trail trl", "Fort Wayne", "VA"), "Levi William", 110);
        lecture.StandardDetails();
        Console.WriteLine();
        lecture.FullDetails();
        Console.WriteLine();
        lecture.ShortDescription();
        Console.WriteLine();

        Reception reception = new Reception("Regina and Josh's Wedding Reception", "Immediately following a wedding ceremony, a reception will be held for Josh and Regina", "04/27/2025", "1pm-4pm", new Address("3820 Jershua Ave.", "Galveston", "TX"), "reservations@rsvp.com");
        reception.StandardDetails();
        Console.WriteLine();
        reception.FullDetails();
        Console.WriteLine();
        reception.ShortDescription();
        Console.WriteLine();

        OutdoorGathering outdoorGathering = new OutdoorGathering("Grace Dance Studio Recital", "A small recital will be held on an outdoor stage for parents", "08/24/2023", "9am-10am", new Address("932 West st.", "Weston", "OK"), "Partly cloudy, 78º f");
        outdoorGathering.StandardDetails();
        Console.WriteLine();
        outdoorGathering.FullDetails();
        Console.WriteLine();
        outdoorGathering.ShortDescription();
        Console.WriteLine();
    }
}