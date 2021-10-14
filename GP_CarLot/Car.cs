using System;
using System.Collections.Generic;
using System.Text;

namespace GP_CarLot
{
    //Parent Class
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        //constructor
        public Car(string make, string model, int year, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Price = price;
        }

        //blank constructor
        public Car()
        {
            
        }
    }
}
