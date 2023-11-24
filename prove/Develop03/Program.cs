using System;
using Develop03;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Scripture Memorization Program!");
        Console.Write("Enter the Scripture Reference (Ex. John 3:16)");
        string Reference = Console.ReadLine();

        Console.Write("Enter the Scripture Text: ");
        string text = Console.ReadLine();

        Scripture scripture = new Scripture(Reference, text);

        Console.Clear();
        scripture.DisplayScripture();

        while (true)
        {
            Console.WriteLine("Press Enter to hide a random word or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;
            else 
                scripture.HideRandomWord();

        }
    
    }
}

       