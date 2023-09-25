using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemapOOP_sConcept
{
    internal class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}");
        }
    }

    class Car : Vehicle
    {
        public int Horsepower { get; set; }

        public Car(string brand, string model, int year, int horsepower)
            : base(brand, model, year)
        {
            Horsepower = horsepower;
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine($"Car Details - Brand: {Brand}, Model: {Model}, Year: {Year}, Horsepower: {Horsepower}");
        }
    }
}
