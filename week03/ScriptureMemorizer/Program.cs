using System;

class Program
{
    static void Main(string[] args)
    {
        // EXCEEDING CORE REQUIREMENTS:
        // Attempted to exceed core requirements by designing the program to support 
        // library-based scripture loading, handling multi-verse references dynamically, 
        // and ensuring the random word hider only targets words that are not already hidden.

        // Set up the scripture reference and text
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding";
        Scripture scripture = new Scripture(reference, text);

        string userInput = "";

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            // Check if all words are hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Great job memorizing!");
                break;
            }

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            if (userInput.Trim().ToLower() == "quit")
            {
                break;
            }

            // Hide 3 random words each time Enter is pressed
            scripture.HideRandomWords(3);
        }
    }
}