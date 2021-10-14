using System;
using System.Collections.Generic;
using System.Text;

namespace GP_CarLot
{
    class Used_Car : Car
    {

        public double Mileage { get; set; }

        public Used_Car(string make, string model, int year, decimal price, double mileage): base(make, model, year, price)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Price = price;
            this.Mileage = mileage;
        }

        public override string ToString()
        {
            return $"Used Car {base.ToString()} Mileage: {Mileage}";
        }

    }
}
