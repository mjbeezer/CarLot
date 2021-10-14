using System;
using System.Collections.Generic;

namespace GP_CarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Dream Team Car Lot!");

            List<Car> carLot = new List<Car>();
            //display available cars
            CarLot.DisplayCars(carLot);
        }
    }
}