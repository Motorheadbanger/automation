using System;
using ParseNumber;

namespace Lesson5
{
    class Task1
    {
        static void Main()
        {
            Console.Write("Submit the first value: ");
            double x = ParseNumberClass.ParseNumber(Console.ReadLine());
            Console.Write("Submit the second value: ");
            double y = ParseNumberClass.ParseNumber(Console.ReadLine());
            Console.WriteLine();

            Rectangle rectangle = new Rectangle(x, y);
            Console.WriteLine($"The rectangle area is {rectangle.AreaCalculator(x, y)}");
            Console.WriteLine($"The rectangle perimeter is {rectangle.PerimeterCalculator(x, y)}");
            Console.ReadKey();
        }
    }
}
