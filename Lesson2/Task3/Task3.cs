using System;
using ParseNumber;

namespace Task3
{
    class Task3
    {
        static void Main(string[] args)
        {
            double result = 0;

            Console.Write("Submit the first number: ");
            double firstNumber = ParseNumberClass.ParseNumber(Console.ReadLine());
            Console.Write("Submit the second number: ");
            double secondNumber = ParseNumberClass.ParseNumber(Console.ReadLine());
            Console.Write("Submit the desired operation (+, -, *, /, ^): ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (operation)
            {
                case '+' :
                    {
                        result = firstNumber + secondNumber;
                        Output(result);
                        break;
                    }
                case '-':
                    {
                        result = firstNumber - secondNumber;
                        Output(result);
                        break;
                    }
                case '*':
                    {
                        result = firstNumber * secondNumber;
                        Output(result);
                        break;
                    }
                case '/':
                    {
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("Error: cannot divide by zero. Exiting...");
                        }
                        else
                        {
                            result = firstNumber / secondNumber;
                            Output(result);
                        }
                        break;
                    }
                case '^':
                    {
                        result = Math.Pow(firstNumber, secondNumber);
                        Output(result);
                        break;
                    }
                default: 
                    {
                        Console.WriteLine("Error: unknown operation. Exiting...");
                        break;
                    }
            }

            Console.ReadKey();
        }

        private static void Output(double result)
        {
            Console.WriteLine($"The result is {result}");
        }
    }
}