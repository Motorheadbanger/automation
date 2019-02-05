using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Specify the first number: ");
            String firstInput = Console.ReadLine();
            double x = ParseNumber(firstInput);
            Console.Write("Specify the second number: ");
            String secondInput = Console.ReadLine();
            double y = ParseNumber(secondInput);
            Console.Write("Specify the third number: ");
            String thirdInput = Console.ReadLine();
            double z = ParseNumber(thirdInput);
            Console.WriteLine("First expression result: " + (x + y) * (z * z - 1));
            Console.WriteLine("Second expression result: " + (x % z - 1) * Math.Sqrt((double)y));
            Console.WriteLine("Third expression result: " + ((x * y) + (y * z)) / (z * z * z));
            Console.Write("Press any key to exit.");
            Console.ReadKey();
        }

        private static double ParseNumber(String input)
        {
            double result;
            bool isNumber = false;
            do
            {
                isNumber = Double.TryParse(input, out result);
                if (!isNumber)
                {
                    Console.Write("Not a number. Try again: ");
                    input = Console.ReadLine();
                }
            } while (!isNumber);
            return result;
        }
    }
}
