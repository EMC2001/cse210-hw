using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Hello Prep3 World!");

        Random random = new Random();
        int returnValue = random.Next(1, 20);
        int Guess = 0;

        Console.WriteLine("Guess the number between 1 and 20");

        while (Guess != returnValue)
        {
            
            string input = Console.ReadLine();
            if (int.TryParse(input, out Guess))
            {
                
                if (Guess < returnValue)
                {
                    Console.WriteLine("Higher");
                }
                else if (Guess > returnValue)
                {
                    Console.WriteLine("Lower");
                }
            }
        }

       
        Console.WriteLine("Congratulations, you guessed the number!");
        Console.ReadLine();
    }
}