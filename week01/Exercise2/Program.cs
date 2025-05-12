using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int gradeNumber = int.Parse(userInput);

        string letter = ("");
        int remainder = gradeNumber % 10;
        string sign = ("");

        if (remainder >= 7)
        {
            sign = "+";
        }
        else if (remainder <= 3)
        {
            sign = "-";
        }

        if (gradeNumber >= 90)
        {
            letter = "A";
            sign = (remainder <= 3) ? "-" : "";
        }
        else if (gradeNumber >= 80)
        {
            letter = "B";
        }
        else if (gradeNumber >= 70)
        {
            letter = "C";
        }
        else if (gradeNumber >= 60)
        {
            letter = "D";
        }
        else if (gradeNumber < 60)
        {
            letter = "F";
            sign = "";
        }

        Console.WriteLine($"Your grade is {letter}{sign}");

        if (gradeNumber >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("Better try harder next time.");
        }
    }
}