using System;
using Irmak;

namespace Irmak
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Details myDetails = new Details();
            string model = myDetails.GetValidModel("Enter Car Model (Mercedes, BMW, Audi): ");
            string engineType = myDetails.GetValidEngine("Enter Engine Type (gasoline, hybrid, diesel): ");
            int year = myDetails.GetValidYear("Enter Car Year (between 1900 and 2025): ");
            float maxSpeed = myDetails.GetValidSpeed("Enter Max Speed (between 0 and 260 km/h): ");
            float fuelCapacity = myDetails.GetValidFloat("Enter Fuel Capacity (liters): ");

            Car myCar = new Car(model, engineType, year, maxSpeed, fuelCapacity);




            myCar.DisplayCarDetails();
        }
    }
}