using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyParking
{
    public class Car
    {

        public string Name { get; set; }

        public string Number { get; set; }

        public string CarsOwnerName { get; set; }

        public override string ToString()
        {
            return Name + " пренадлежит " + CarsOwnerName;
        }
    }
}
