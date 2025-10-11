using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Enter numbers to add to the list. Press 0 to stop.");
        List<int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string numberStr = Console.ReadLine();
            number = int.Parse(numberStr);


            if (number == 0)
            {
                double avg = numbers.Average();
                int highest = numbers.Max();

                Console.WriteLine($"The sum is {numbers.Sum()}");
                Console.WriteLine($"The average is: {avg}");
                Console.WriteLine($"The highest number is: {highest}");
                break;
            }

            numbers.Add(number);
        }


    }
}