using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarParts carburetor = new CarParts("Carburetor", 105.50);
            CarParts steeringWheel = new CarParts("Steering wheel", 25);
            CarParts bucketSeat = new CarParts("Bucket seat", 150);
            CarParts seat = new CarParts("Seat", 50);
            Car sportsCar = new Car("Sportscar", new CarParts[]{carburetor, steeringWheel, bucketSeat});
            Car compactCar = new Car("Compact car", new CarParts[] { carburetor, steeringWheel, seat });

            Console.Write("Submit the car name: ");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "Sportscar" :
                    Console.WriteLine($"Total parts cost is {Calculator.Calculate(sportsCar)}");
                    break;
                case "Compact car":
                    Console.WriteLine($"Total parts cost is {Calculator.Calculate(compactCar)}");
                    break;
                default:
                    Console.WriteLine("Not found");
                    break;
            }
            Console.ReadKey();
        }
    }
}
