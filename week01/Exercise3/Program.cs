using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int answer = -1;


        while (answer != magicNumber)
        {
            Console.Write("What is your guess?");
            string guess = Console.ReadLine();
            answer = int.Parse(guess);

            if (answer > magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (answer < magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You Guessed It");
            }
        }

    }
}