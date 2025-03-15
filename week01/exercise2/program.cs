// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Ask for the user's grade percentage
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter = "";

        // Determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine if the user passed
        if (grade >= 70)
        {
            Console.WriteLine($"Your grade is {letter}. Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine($"Your grade is {letter}. Keep working hard, you'll do better next time!");
        }
    }
}

