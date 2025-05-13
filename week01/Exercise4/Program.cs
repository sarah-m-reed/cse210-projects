using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        List<int> numbers = new List<int>();
        int sum = 0;
        int largest = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number != 0)
            {
                numbers.Add(number);
                sum += number;
            }
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        foreach (int item in numbers)
        {
            if (item > largest)
            {
                largest = item;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}