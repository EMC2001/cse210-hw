using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the guessing game! Start guessing a number from 1 to 100");
        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int guessNumber = -1;

        while (guessNumber != number)
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guessNumber = int.Parse(userGuess);
        
            if (guessNumber == number)
            {
                Console.Write("Right on!");
            }
            else if (guessNumber > number)
            {
                Console.WriteLine("Guess Lower");
            }
            else
            {
                Console.WriteLine("Guess Higher");
            }
        }
      
    }
}