using System;

namespace Task3
{
    class Task3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Specify the first line: ");
            string firstLine = Console.ReadLine().ToUpper();
            Console.WriteLine("Specify the second line: ");
            string secondLine = Console.ReadLine().ToUpper();
            Console.WriteLine("Specify the third line: ");
            string thirdLine = Console.ReadLine().ToUpper();

            Console.WriteLine("String " + firstLine + " starts from " + secondLine + ": " + firstLine.StartsWith(secondLine));
            Console.WriteLine("String " + firstLine + " ends with " + thirdLine + ": " + firstLine.EndsWith(thirdLine));
            Console.Write("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
