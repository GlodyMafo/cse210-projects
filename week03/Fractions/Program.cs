using System;

class Program
{
    static void Main(string[] args)
    {
       Fraction F1 = new Fraction();
       Console.WriteLine(F1.GetFractionString());
       Console.WriteLine(F1.GetDecimalValue());

       Fraction F2 = new Fraction (5);
       Console.WriteLine(F2.GetFractionString());
       Console.WriteLine(F2.GetDecimalValue());

       Fraction F3 = new Fraction (12, 4);
       Console.WriteLine(F3.GetFractionString());
       Console.WriteLine(F3.GetDecimalValue());
    }
}