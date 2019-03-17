using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class CarParts
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public CarParts(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
