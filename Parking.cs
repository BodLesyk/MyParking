using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyParking
{
    class Parking
    {
        private List<Car> _cars = new List<Car>();

        public string Name { get; set; }

        private const int MAX_CARS = 100;

        public int Count => _cars.Count;

        public Car this[string number]
        {
            get
            {
                var car = _cars.FirstOrDefault(x => x.Number == number);
                return car;
            }
        }

        public int Add(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car), "Car is null");
            }

            if (_cars.Count < MAX_CARS)
            {
                _cars.Add(car);
                return _cars.Count;
            }
            return -1;

        }

        public void GoOut(string number)
        {
            if (string.IsNullOrEmpty(number))
            {
                throw new ArgumentNullException(nameof(number), "Number is empty");
            }

            var car = _cars.FirstOrDefault(x => x.Number == number);

            if (car != null)
            {
                _cars.Remove(car);
            }
        }

        public void ShowCars()
        {
            foreach(var car in _cars)
            {
                Console.WriteLine($" Владелец - {car.CarsOwnerName}, Марка -  {car.Name}, Номер - {car.Number} ");
            }
        }

    }
}
