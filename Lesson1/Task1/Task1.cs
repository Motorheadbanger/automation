﻿using System;
using ParseNumber;

namespace Task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            Console.Write("Specify the first number: ");
            string firstInput = Console.ReadLine();
            double x = ParseNumberClass.ParseNumber(firstInput);

            Console.Write("Specify the second number: ");
            string secondInput = Console.ReadLine();
            double y = ParseNumberClass.ParseNumber(secondInput);

            Console.Write("Specify the third number: ");
            string thirdInput = Console.ReadLine();
            double z = ParseNumberClass.ParseNumber(thirdInput);

            Console.WriteLine($"First expression result: {(x + y) * (z * z - 1)}");
            Console.WriteLine($"Second expression result: {(x % z - 1) * Math.Sqrt(y)}");
            Console.WriteLine($"Third expression result: {(x * y + y * z) / (z * z * z)}");
            Console.Write("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
