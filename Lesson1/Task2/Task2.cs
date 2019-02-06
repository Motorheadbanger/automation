using System;
using IsNumber;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.Write("Specify width: ");
            String widthInput = Console.ReadLine();
            double width = IsNumberClass.ParseNumber(widthInput);

            Console.Write("Specify height: ");
            String heightInput = Console.ReadLine();
            double height = IsNumberClass.ParseNumber(heightInput);

            Console.Write("Specify depth: ");
            String depthInput = Console.ReadLine();
            double depth = IsNumberClass.ParseNumber(depthInput);

            double result = Math.Sqrt(((width * width) + (height * height)) + (depth * depth));
            Console.WriteLine("Parallelepiped diagonal length: " + result);
            Console.Write("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
