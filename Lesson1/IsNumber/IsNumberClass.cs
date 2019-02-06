using System;

namespace IsNumber
{
    public class IsNumberClass
    {
        public static double ParseNumber(String input)
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
