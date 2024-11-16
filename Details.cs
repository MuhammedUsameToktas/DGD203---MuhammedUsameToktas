using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irmak
{
    internal class Details
    {
        public string GetValidModel(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string model = Console.ReadLine();
                if (model.Equals("Mercedes", StringComparison.OrdinalIgnoreCase) ||
                    model.Equals("BMW", StringComparison.OrdinalIgnoreCase) ||
                    model.Equals("Audi", StringComparison.OrdinalIgnoreCase))
                {
                    return model;
                }
                else
                {
                    Console.WriteLine("Invalid model. Please enter Mercedes, BMW, or Audi.");
                }
            }
        }
        public string GetValidEngine(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string engineType = Console.ReadLine();
                if (engineType.Equals("gasoline", StringComparison.OrdinalIgnoreCase) ||
                    engineType.Equals("hybrid", StringComparison.OrdinalIgnoreCase) ||
                    engineType.Equals("diesel", StringComparison.OrdinalIgnoreCase))
                {
                    return engineType;
                }
                else
                {
                    Console.WriteLine("Invalid engine type. Please enter gasoline, hybrid, or diesel.");
                }
            }
        }

        public int GetValidYear(string prompt)
        {
            int year;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out year) && year >= 1900 && year <= 2025)
                {
                    return year;
                }
                else
                {
                    Console.WriteLine("Invalid year. Please enter a year between 1900 and 2025.");
                }
            }
        }

        public float GetValidSpeed(string prompt)
        {
            float speed;
            while (true)
            {
                Console.Write(prompt);
                if (float.TryParse(Console.ReadLine(), out speed) && speed >= 0 && speed <= 260)
                {
                    return speed;
                }
                else
                {
                    Console.WriteLine("Invalid speed. Please enter a speed between 0 and 260 km/h.");
                }
            }
        }

        public float GetValidFloat(string prompt)
        {
            float result;
            while (true)
            {
                Console.Write(prompt);
                if (float.TryParse(Console.ReadLine(), out result) && result > 0)
                    return result;
                else
                    Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }
    }
}
