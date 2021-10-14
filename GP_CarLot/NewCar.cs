using System;
using System.Collections.Generic;
using System.Text;

namespace GP_CarLot
{
    class NewCar : Car
    {
        public bool IsTrue;

        public NewCar(string make, string model, int year, decimal price, bool isTrue) : base(make, model, year, price)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Price = price;
            this.IsTrue = isTrue;
        }

        public NewCar()
        {
            this.Make = "";
            this.Model = "";
            this.Year = 0;
            this.Price = 0;
            this.IsTrue = true;
        }

        public override string ToString()
        {
            return base.ToString() + $" New : {IsTrue}";
        }

    }
}
