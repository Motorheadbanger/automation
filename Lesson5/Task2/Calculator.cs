namespace Task2
{
    class Calculator
    {
        public static double Calculate(Car car)
        {
            double result = 0.0;
            foreach (CarParts part in car.PartList)
            {
                result += part.Price;
            }
            return result;
        }
    }
}
