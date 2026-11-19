using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            Console.WriteLine($"You entered a number {number}");
        }
        else
        {
            Console.WriteLine("Error: a non-integer value was entered.");
        }
    }
}