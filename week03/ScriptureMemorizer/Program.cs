using System;

class Program
{
    static void Main(string[] args)
    {
        // Test stub initialization
        Reference refObj = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(refObj, "Trust in the Lord with all thine heart and lean not unto thine own understanding");

        Console.WriteLine(scripture.GetDisplayText());
    }
}