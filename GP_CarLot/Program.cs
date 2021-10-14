using System;
using System.Collections.Generic;

namespace GP_CarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Dream Team Car Lot!");
            CarLot newLot = new CarLot();
            
            //display available cars
            newLot.DisplayCars();
        }
    }
}