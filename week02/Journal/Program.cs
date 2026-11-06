using System;

// Exceeding Requirements / Creativity:
// 1. Used a unique separator (~|~) during file serialization to cleanly handle any commas or 
//    special characters within user journal text without breaking file loading logic.
// 2. Encapsulated prompt handling entirely within the PromptGenerator class to keep the 
//    main loop clean and modular.

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string response = Console.ReadLine();
            if (int.TryParse(response, out choice))
            {
                if (choice == 1)
                {
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string entryText = Console.ReadLine();
                    
                    // Get current date
                    string dateText = DateTime.Now.ToShortDateString();

                    Entry newEntry = new Entry();
                    newEntry._date = dateText;
                    newEntry._promptText = prompt;
                    newEntry._entryText = entryText;

                    theJournal.AddEntry(newEntry);
                }
                else if (choice == 2)
                {
                    theJournal.DisplayAll();
                }
                else if (choice == 3)
                {
                    Console.Write("What is the filename? ");
                    string filename = Console.ReadLine();
                    theJournal.SaveToFile(filename);
                }
                else if (choice == 4)
                {
                    Console.Write("What is the filename? ");
                    string filename = Console.ReadLine();
                    theJournal.LoadFromFile(filename);
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select between 1 and 5.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
            Console.WriteLine();
        }
    }
}