using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace LabSpecial16081219
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Bob's Motor Mall");
            Console.WriteLine("Enter the number of cars you want to input.");
            int quantity = int.Parse(Console.ReadLine());

            List<Car> amount = new List<Car>(quantity);


            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine("Please input the car model");
                string model = Console.ReadLine().Trim();

                Console.WriteLine("Please input a vehicle make");
                string make = Console.ReadLine().Trim();

                Console.WriteLine("Please input vehicle year.");
                string w = Console.ReadLine().Trim();
                int year = Convert.ToInt32(w);

                Console.WriteLine("Please input vehicle price.");
                string x = Console.ReadLine().Trim();
                double price = Convert.ToDouble(x);

                Car input = new Car(year, make, model, price);
                amount.Add(new Car(year, make, model, price));
            }

            Console.WriteLine("Current Inventory:");
            for (int i = 0; i < amount.Count; i++)
            {
                int v = i + 1;
                Car full = amount[i];
                Console.WriteLine(full.Model + " " + full.Make + " " + full.Year + " " + full.Price.ToString("C2", CultureInfo.CurrentCulture));
            }

        }
    }
}
