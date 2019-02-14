using System;
using ParseNumber;

namespace Task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.Write("Specify width: ");
            string widthInput = Console.ReadLine();
            double width = ParseNumberClass.ParseNumber(widthInput);

            Console.Write("Specify height: ");
            string heightInput = Console.ReadLine();
            double height = ParseNumberClass.ParseNumber(heightInput);

            Console.Write("Specify depth: ");
            string depthInput = Console.ReadLine();
            double depth = ParseNumberClass.ParseNumber(depthInput);

            double result = Math.Sqrt((width * width + height * height) + depth * depth);
            Console.WriteLine("Parallelepiped diagonal length: " + result);
            Console.Write("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
