using System;
using IsNumber;

namespace Task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            Console.Write("Specify the first number: ");
            string firstInput = Console.ReadLine();
            double x = IsNumberClass.ParseNumber(firstInput);

            Console.Write("Specify the second number: ");
            string secondInput = Console.ReadLine();
            double y = IsNumberClass.ParseNumber(secondInput);

            Console.Write("Specify the third number: ");
            string thirdInput = Console.ReadLine();
            double z = IsNumberClass.ParseNumber(thirdInput);

            Console.WriteLine("First expression result: " + (x + y) * (z * z - 1));
            Console.WriteLine("Second expression result: " + (x % z - 1) * Math.Sqrt((double)y));
            Console.WriteLine("Third expression result: " + ((x * y) + (y * z)) / (z * z * z));
            Console.Write("Press any key to exit.");
            Console.ReadKey();
        }

        
    }
}
