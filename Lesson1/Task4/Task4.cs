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
            Console.Write("Specify the symbol: ");
            char symbol = Console.ReadKey().KeyChar;
            Console.WriteLine();

            string resultString = firstLine + secondLine;
            Console.WriteLine($"Index of {symbol} in {resultString}: {resultString.LastIndexOf(symbol)}");
            Console.Write("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
