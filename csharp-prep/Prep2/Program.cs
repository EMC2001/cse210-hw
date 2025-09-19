using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please input your grade percentage: ");
        string grade = Console.ReadLine();
        int numberGrade = int.Parse(grade);

        string letterGrade = "";

        if (numberGrade >= 90)
        {
            letterGrade = "A";
        }
        else if (numberGrade >= 80)
        {
            letterGrade = "B";
        }
        else if (numberGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (numberGrade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"You grade: {letterGrade}");

        if (numberGrade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Try harder bro");
        }
    }
}