using System;

namespace Calculator
{
    class Program
    {
static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator program");
            int num1 = GetNumber("Enter your first number:");
            int num2 = GetNumber("Enter your second number:");
        }

        static int GetNumber(string prompt)
        {
            int number;
            Console.WriteLine(prompt);
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            return number;
        }
    }
}
