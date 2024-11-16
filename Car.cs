using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Irmak
{
    internal class Car
    {
        public string Model { get; set; }
        public string EngineType { get; set; }
        public int Year { get; set; }
        public float MaxSpeed { get; set; }
        public float FuelCapacity { get; set; }

        public Car(string model, string engineType, int year, float maxSpeed, float fuelCapacity)
        {
            Model = model;
            EngineType = engineType;
            Year = year;
            MaxSpeed = maxSpeed;
            FuelCapacity = fuelCapacity;
        }

        public void DisplayCarDetails()
        {
            Console.WriteLine("\nCar Details:");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Engine Type: {EngineType}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Max Speed: {MaxSpeed} km/h");
            Console.WriteLine($"Fuel Capacity: {FuelCapacity} liters");

            if (MaxSpeed > 180)
            {
                Console.WriteLine("Your Car is very fast.");
            }
            else if (MaxSpeed > 110 && MaxSpeed <= 180)
            {
                Console.WriteLine("Your Car is not bad.");
            }
            else if (MaxSpeed > 0 && MaxSpeed <= 110)
            {
                Console.WriteLine("Your Car is too slow.");
            }
            else if (MaxSpeed <= 0)
            {
                Console.WriteLine("Your car doesn't start.");
            }

        }
    }
}
