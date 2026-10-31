using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Generate a random magic number from 1 to 100
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        // Initialize guess with a value that doesn't match the magic number
        int guess = -1;

        // 2. Loop as long as the guess does not match the magic number
        while (guess != magicNumber)
        {
            // Ask the user for a guess
            Console.Write("What is your guess? ");
            string answer = Console.ReadLine();
            guess = int.Parse(answer);

            // 3. Determine if the user needs to guess higher or lower
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}