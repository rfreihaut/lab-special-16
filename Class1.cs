using System;
using System.Collections.Generic;
using System.Text;

namespace LabSpecial16081219
{
    class Car
    {



        public double Price { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }


        public Car(int year, string make, string model, double price)
        {
            this.Year = year;
            this.Make = make;
            this.Model = model;
            this.Price = price;
        }

    }
}