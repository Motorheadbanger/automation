using System;

namespace ParseNumber
{
    public class ParseNumberClass
    {
        public static double ParseNumber(String input)
        {
            double result = 0.0;
            bool isNumber = false;
            while (!isNumber)
            {
                isNumber = Double.TryParse(input, out result);
                if (!isNumber)
                {
                    Console.Write("Not a number. Try again: ");
                    input = Console.ReadLine();
                }
            }

            return result;
        }
    }
}
