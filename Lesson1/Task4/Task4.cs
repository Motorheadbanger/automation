using System;

namespace Task4
{
    class Task4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Specify the first line: ");
            string firstLine = Console.ReadLine();
            Console.WriteLine("Specify the second line: ");
            string secondLine = Console.ReadLine();
            Console.WriteLine("Specify the symbol: ");
            string symbolInput = Console.ReadLine();
            char symbol = ParseSymbol(symbolInput);

            string resultString = firstLine + secondLine;
            Console.WriteLine("Index of " + symbol + " in " + resultString + ": " + resultString.LastIndexOf(symbol));
            Console.Write("Press any key to exit.");
            Console.ReadKey();
        }

        public static char ParseSymbol(String input)
        {
            char result;
            bool isSymbol = false;
            char[] parsedInput = input.ToCharArray();
            result = parsedInput[0];
            do
            {
                if (parsedInput.Length == 1)
                {
                    isSymbol = true;
                }
                if (!isSymbol)
                {
                    Console.Write("Not a symbol. Try again: ");
                    input = Console.ReadLine();
                    parsedInput = input.ToCharArray();
                    result = parsedInput[0];
                }
            } while (!isSymbol);
            return result;
        }
    }
}
