using System;

namespace SimpleCalculator
{
    public class Calculator
    {
        public static void Main()
        {
            Console.WriteLine("******** Welcome to Online Calculator ********");
            Console.WriteLine("\nEnter an expression (e.g., 2 + 3)");

            // Read input expression as a string
            // Trim leading and trailing double qoutes
            string exp = Console.ReadLine().Trim('"');

            // Split the input expression using whitespace
            // Store each token in a string array
            string[] input = exp.Split(' ');

            // Check input array length
            if (input.Length != 3)
            {
                Console.WriteLine("Invalid input format.");
                return;
            }

            // Declare floating variables
            float num1, num2;

            // Parse input array elements to float type
            // Store them in num1 and num2, respectively
            if (!float.TryParse(input[0], out num1) || !float.TryParse(input[2], out num2))
            {
                Console.WriteLine("Invalid number format.");
                return;
            }

            // Store the operator in a char variable
            char operation = input[1][0];
            double result = 0.0;

            // Check the operator
            switch (operation)

      {
        case '+':
                    result = num1 + num2;
                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;

                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Division by zero is not allowed.");
                    break;

                default:
                    Console.WriteLine("Invalid operation. Please use one of the following: +, -, *, /");
                    return;
                }

                // Display the result
                Console.WriteLine("Result: " + result);
            }
        }
    }
