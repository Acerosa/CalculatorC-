using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    // Define the main program class
    class Program
    {
        // Define the Main method, the entry point of the program
        static void Main(string[] args)
        {
            // Declare variables to store the first number, second number, operator, and result
            int num1;
            int num2;
            string opp;
            int result;

            // Display a welcome message
            Console.WriteLine("Welcome to the calculator program");

            // Prompt the user to enter the first number
            Console.WriteLine("Enter your first number!");
            // Read and convert the first number from the console input
            num1 = Convert.ToInt32(Console.ReadLine());

            // Prompt the user to enter the second number
            Console.WriteLine("Enter your second number!");
            // Read and convert the second number from the console input
            num2 = Convert.ToInt32(Console.ReadLine());

            // Prompt the user to choose the desired operation
            Console.WriteLine("Please choose your desired operation");
            Console.WriteLine("For addition choose (+),\n For subtraction choose (-), \n For division choose (/), \n For multiplication choose (*)");
            // Read the chosen operation from the console input
            opp = Console.ReadLine();

            // Perform the calculation based on the chosen operation
            if (opp == "+")
            {
                // Addition
                result = num1 + num2;
            }
            else if (opp == "-")
            {
                // Subtraction
                result = num1 - num2;
            }
            else if (opp == "/")
            {
                // Division
                result = num1 / num2;
            }
            else if (opp == "*")
            {
                // Multiplication
                result = num1 * num2;
            }
            else
            {
                // Handle invalid operation
                Console.WriteLine("Not a valid operation selected!");
                return; // Exit the program if the operation is invalid
            }

            // Display the result of the calculation
            Console.WriteLine("The result is: " + result);

            // Wait for a key press before exiting
            Console.ReadKey();
        }
    }
}
