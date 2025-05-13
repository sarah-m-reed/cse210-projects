using System;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayMessage();

        string name = PromptUserName();

        int favoriteNumber = PromptUserNumber();

        int square = SquareNumber(favoriteNumber);

        DisplayResult(name, square);
        
        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the Program");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userInput = Console.ReadLine();
            int favoriteNumber = int.Parse(userInput);
            return favoriteNumber;
        }

        static int SquareNumber(int favoriteNumber)
        {
            int square = favoriteNumber * favoriteNumber;
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}