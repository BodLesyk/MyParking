using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyParking
{
    class Program
    {
        static void Main(string[] args)
        {

            var cars = new List<Car>()
            {
                new Car() {Name = "Mini Couper", Number = "1804", CarsOwnerName = "Mary Shevchenko" },
                new Car () {Name = "Nissan Armada", Number = "2703", CarsOwnerName = "Yuriy Lesyk" },
                new Car () {Name = "Audi Q7", Number = "1603", CarsOwnerName = "Bohdan Lesyk" }
            };

            var parking = new Parking();

            foreach(var car in cars)
            {
                parking.Add(car);
            }


            var car2 = new Car() { Name = "Mercedes Benz", Number = "0204", CarsOwnerName = "Daria Lesyk" };



            Console.WriteLine(parking.Add(car2)); 

            parking.ShowCars();

            Console.WriteLine(parking["1804"]?.Name);

            Console.ReadKey();
        }
    }
}
