using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Ask the user for their grade percentage and parse it
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        // 3. Create a 'letter' variable to hold the grade (Core Requirement 3)
        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Display the letter grade once at the end
        Console.WriteLine($"Your grade is: {letter}");

        // 2. Check if the user passed or failed (Core Requirement 2)
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! Keep practicing and you'll get it next time.");
        }
    }
}