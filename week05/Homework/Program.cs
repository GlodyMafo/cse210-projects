using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment as1 = new Assignment("Agapy Mafo", "Functions");
        Console.WriteLine(as1.GetSummary());

        MathAssignment as2 = new MathAssignment("Deo Mafo", "Addition", "8", "10-25");
        Console.WriteLine(as2.GetSummary());
        Console.WriteLine(as2.GetHomeWorkList());

    }
}