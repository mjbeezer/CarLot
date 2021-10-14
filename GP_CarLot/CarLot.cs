using System;
using System.Collections.Generic;
using System.Text;

namespace GP_CarLot
{
    class CarLot
    {
        List<Car> carLot = new List<Car>();



        public CarLot()
        {
            NewCar Miata = new NewCar("Mazada", "Miata", 2022, 30000, true);
            NewCar Corvette = new NewCar("Chevy", "Corvette", 2022, 40000, true);
            NewCar Corolla = new NewCar("Toyota", "Corolla", 2022, 30000, true);
            Used_Car Mustang = new Used_Car("Ford", "Fox Body Mustang", 1990, 10000, 75000);
            Used_Car F150 = new Used_Car("Ford", "F150", 1970, 7500, 1000);
            Used_Car ClubWagon = new Used_Car("Ford", "Club Wagon", 1969, 800, 100000);

            carLot.Add(Miata);
            carLot.Add(Corvette);
            carLot.Add(Corolla);
            carLot.Add(Mustang);
            carLot.Add(F150);
            carLot.Add(ClubWagon);


        }


        public static string CheckInput()
        {

            string result = "";
            while (result == "")
            {
                Console.WriteLine("Which would you like to add? New / Used");
                string response = Console.ReadLine().ToLower().Trim();
                if (response == "new")
                {

                    result = "new";
                }

                else if (response == "used")
                {

                    result = "used";

                }

                else
                {
                    Console.WriteLine("That was not a valid answer");
                }

            }

            return result;

        }

        public static void AddToList(List<Car> carLot)
        {
            string make = "";
            string model = "";
            int year = 0;
            decimal price = 0;
            double mileage = 0;
            string choice = "";


            choice = CheckInput();





            if (choice == "new")
            {
                Console.WriteLine("\nPlease enter the car's make: ");
                make = Console.ReadLine();

                Console.WriteLine("\nPlease enter the car's model: ");
                model = Console.ReadLine();

                while (true)
                {
                    try
                    {
                        Console.WriteLine("\nPlease enter the car's year: ");
                        year = int.Parse(Console.ReadLine());
                        break;
                    }

                    catch
                    {
                        Console.WriteLine("\nPlease enter a valid number");

                    }
                }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("\nPlease enter the car's price: ");
                        price = decimal.Parse(Console.ReadLine());
                        break;
                    }

                    catch
                    {
                        Console.WriteLine("\nPlease enter a valid number");

                    }
                }

                NewCar newCar = new NewCar(make, model, year, price, true);
                carLot.Add(newCar);
            }

            else if (choice == "used")
            {
                Console.WriteLine("\nPlease enter the car's make: ");
                make = Console.ReadLine();

                Console.WriteLine("\nPlease enter the car's model: ");
                model = Console.ReadLine();

                while (true)
                {
                    try
                    {
                        Console.WriteLine("\nPlease enter the car's year: ");
                        year = int.Parse(Console.ReadLine());
                        break;
                    }

                    catch
                    {
                        Console.WriteLine("\nPlease enter a valid number");

                    }
                }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("\nPlease enter the car's price: ");
                        price = decimal.Parse(Console.ReadLine());
                        break;
                    }

                    catch
                    {
                        Console.WriteLine("\nPlease enter a valid number");

                    }

                }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("\nPlease enter the car's mileage: ");
                        mileage = double.Parse(Console.ReadLine());
                        break;
                    }

                    catch
                    {
                        Console.WriteLine("\nPlease enter a valid number");

                    }

                }
                Used_Car usedCar = new Used_Car(make, model, year, price, mileage);
                carLot.Add(usedCar);

            }


        }
    }
}
