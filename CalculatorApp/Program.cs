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
            string operation = GetOperation();
            
             int result = PerformCalculation(num1, num2, operation);

            Console.WriteLine($"The result of {num1} {operation} {num2} is: {result}");

            Console.ReadKey();
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

        static string GetOperation()
        {
            Console.WriteLine("Please choose your desired operation:");
            Console.WriteLine("For addition choose (+),\nFor subtraction choose (-),\nFor division choose (/),\nFor multiplication choose (*)");

            string operation;
            while (true)
            {
                operation = Console.ReadLine();
                if (operation == "+" || operation == "-" || operation == "/" || operation == "*")
                {
                    break;
                }
                Console.WriteLine("Invalid operation. Please choose a valid operation (+, -, /, *).");
            }
            return operation;
        }
        static int PerformCalculation(int num1, int num2, string operation)
            {
                int result = 0;
                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                }
                return result;
          }
     }
}

