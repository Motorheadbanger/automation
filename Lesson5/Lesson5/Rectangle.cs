namespace Lesson5
{
    class Rectangle
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        public double AreaCalculator(double x, double y)
        {
            double result = x * y;
            return result;
        }

        public double PerimeterCalculator(double x, double y)
        {
            double result = 2 * x + 2 * y;
            return result;
        }
    }
}