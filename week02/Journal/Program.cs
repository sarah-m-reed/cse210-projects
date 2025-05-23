using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool exit = false;
        Console.WriteLine("Welcome to the Journal Program!");

        while (!exit)
        {
            Console.WriteLine("Please Select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToString("yyyy-MM-dd");

                    Entry newEntry = new Entry()
                    {
                        _date = date,
                        _promptText = prompt,
                        _entryText = response
                    };

                    theJournal.AddEntry(newEntry);
                    break;

                case "2":
                    Console.WriteLine("Your Journal Entries:");
                    theJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to load the journal: ");
                    string loadFile = Console.ReadLine();
                    theJournal.LoadFromFile(loadFile);
                    break;

                case "4":
                    Console.Write("Enter filename to save the journal: ");
                    string saveFile = Console.ReadLine();
                    theJournal.SaveToFile(saveFile);
                    break;

                case "5":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}